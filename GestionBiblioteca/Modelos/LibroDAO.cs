using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using GestionBiblioteca.DTOs;

namespace GestionBiblioteca.Modelos
{
    // Autor: David Redondo Serrano
    // Fecha: Mayo 2026
    // Descripción: Acceso a datos y operaciones CRUD de libros en la base de datos.
    public class LibroDAO
    {
        // Usaremos un campo privado para el contexto opcional
        private Modelo contexto;

        // =========================================================================
        // CONSTRUCTORES
        // =========================================================================

        // Constructor vacío (para otros usos)
        public LibroDAO() {}

        // Constructor que acepta el contexto
        public LibroDAO(Modelo contexto)
        {
            this.contexto = contexto;
        }

        /// Elimina un libro y todas sus lecturas asociadas de forma explícita (simulando cascada).
        public bool EliminarLibro(int idLibro)
        {
            using (var contexto = new GestionBiblioteca.Modelo())
            {
                // Encontrar las Lecturas asociadas (es más eficiente eliminarlas primero)
                // Se asume que LecturasDTO tiene un campo IdLibro
                var lecturas = contexto.Lecturas.Where(l => l.IdLibro == idLibro).ToList();

                // Eliminar el rango de Lecturas
                if (lecturas.Any())
                {
                    contexto.Lecturas.RemoveRange(lecturas);
                }

                // Encontrar el Libro a eliminar
                var libro = contexto.Libros.Find(idLibro);

                if (libro != null)
                {
                    // Eliminar el Libro
                    contexto.Libros.Remove(libro);

                    // Guardar los cambios. La operación será atómica (todo o nada).
                    contexto.SaveChanges();
                    return true;
                }

                // Esto solo ocurriría si el libro ya no existía, pero las lecturas sí.
                // Si el libro no existe, devolvemos false (o true si se quiere indicar que la tarea terminó).
                return false;
            }
        }       

        // Guarda un NUEVO registro de Libro en la base de datos y obtiene el ID generado.               
        public int InsertarLibro(LibroDTO registroLibro, LecturasDTO registroLectura)
        {
            using (var contexto = new Modelo())
            {
                // Iniciar la transacción nativa de EF/ADO.NET
                using (var dbContextTransaction = contexto.Database.BeginTransaction())
                {
                    try
                    {
                        // Guardar el Libro
                        contexto.Libros.Add(registroLibro);
                        contexto.SaveChanges(); // El IdLibro se genera aquí

                        // Asignar el ID generado a la Lectura
                        registroLectura.IdLibro = registroLibro.IdLibro;

                        // Guardar la Lectura
                        contexto.Lecturas.Add(registroLectura);
                        contexto.SaveChanges();

                        // Confirmar la transacción
                        dbContextTransaction.Commit();

                        return registroLibro.IdLibro;
                    }
                    catch (Exception)
                    {
                        // Si algo falla (incluso el segundo SaveChanges), se revierte.
                        dbContextTransaction.Rollback();
                        throw; // Relanzar la excepción para que el Controlador la maneje
                    }
                }
            }
        }

        // Actualiza un libro y su lectura asociada. Asume que ya existen en la BD.
        public bool ActualizarLibro(LibroDTO libro, LecturasDTO lectura)
        {
            using (var contexto = new GestionBiblioteca.Modelo())
            {
                // Recuperar el libro existente de la BD (EF guarda el estado original)
                var libroExistente = contexto.Libros.Find(libro.IdLibro);
                if (libroExistente == null) return false;

                // Aplicar solo los campos que el usuario puede modificar
                libroExistente.Titulo = libro.Titulo;
                libroExistente.Autor = libro.Autor;
                libroExistente.Editorial = libro.Editorial;
                libroExistente.Genero = libro.Genero;
                libroExistente.Idioma = libro.Idioma;
                libroExistente.FechaPublicacion = libro.FechaPublicacion;

                // Recuperar la lectura existente de la BD
                var lecturaExistente = contexto.Lecturas.Find(lectura.IdLectura);
                if (lecturaExistente == null) return false;

                // Aplicar solo los campos que el usuario puede modificar
                lecturaExistente.Estado = lectura.Estado;
                lecturaExistente.Comentario = lectura.Comentario;
                lecturaExistente.NumeroLectura = lectura.NumeroLectura;

                // EF compara con el estado original y genera solo los UPDATE necesarios
                int filasAfectadas = contexto.SaveChanges();
                return filasAfectadas > 0;
            }
        }

        // Obtiene la vista de libros aplicando filtros condicionales.      
        public List<LibroVistaDTO> ObtenerLibrosFiltrados(string autor, string editorial, string estado, string genero)
        {
            using (var contexto = new GestionBiblioteca.Modelo())
            {
                // Construcción diferida: EF aún no ejecuta SQL
                var consulta = (from l in contexto.Libros
                                join lec in contexto.Lecturas on l.IdLibro equals lec.IdLibro
                                select new
                                {
                                    l,
                                    lec
                                });

                // Filtros opcionales: solo se aplican si el parámetro tiene valor
                if (!string.IsNullOrWhiteSpace(autor))
                {
                    consulta = consulta.Where(x => x.l.Autor.Contains(autor));
                }
                if (!string.IsNullOrWhiteSpace(editorial))
                {
                    consulta = consulta.Where(x => x.l.Editorial.Contains(editorial));
                }
                if (!string.IsNullOrWhiteSpace(genero))
                {
                    consulta = consulta.Where(x => x.l.Genero == genero);
                }
                if (!string.IsNullOrWhiteSpace(estado))
                {
                    consulta = consulta.Where(x => x.lec.Estado == estado);
                }

                // Proyección al DTO de vista + ejecución real de la consulta SQL
                var resultado = consulta.Select(x => new LibroVistaDTO
                {
                    // proyección de todos los campos
                    IdLibro = x.l.IdLibro,
                    Título = x.l.Titulo,
                    Autor = x.l.Autor,
                    Editorial = x.l.Editorial,
                    Género = x.l.Genero,
                    Idioma = x.l.Idioma,
                    Fecha_Publicación = x.l.FechaPublicacion,
                    EstadoActual = x.lec.Estado,
                    Número_Lectura = x.lec.NumeroLectura,
                    Comentario = x.lec.Comentario
                }).ToList(); // Aquí EF genera y ejecuta el SQL final

                return resultado;
            }
        }

        // Obtiene un Libro y su Lectura asociada para la edición. Devuelve un objeto que contiene ambas entidades.      
        public LibroCompletoDTO ObtenerLibroPorId(int idLibro)
        {
            using (var contexto = new GestionBiblioteca.Modelo())
            {
                // Usaremos la sintaxis de consulta para obtener el libro y su lectura asociada
                var resultado = (from l in contexto.Libros
                                 join lec in contexto.Lecturas on l.IdLibro equals lec.IdLibro
                                 where l.IdLibro == idLibro
                                 select new LibroCompletoDTO // Creamos un DTO específico para la transferencia
                                 {
                                     Libro = l,
                                     Lectura = lec
                                 }).FirstOrDefault();

                return resultado;
            }
        }
        
    }
}