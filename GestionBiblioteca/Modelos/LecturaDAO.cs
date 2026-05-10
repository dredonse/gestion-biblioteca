// LecturaDAO.cs

using GestionBiblioteca.Modelos;
using System;
using System.Data.Entity.Validation;

namespace GestionBiblioteca.Modelos
{
    // Reservado para uso futuro
    public class LecturaDAO
    {

        // Usaremos un campo privado para el contexto opcional
        private Modelo _contexto;

        // Constructor que acepta el contexto
        public LecturaDAO(Modelo contexto)
        {
            _contexto = contexto;
        }

        // Constructor vacío (para otros usos)
        public LecturaDAO()
        {
        }
        /// <summary>
        /// Guarda un nuevo registro de Lectura en la base de datos.
        /// Asume que el IdLibro ya ha sido asignado al registroLectura por el Controlador.
        /// </summary>
        /// <param name="registroLectura">El DTO de Lectura a guardar.</param>
        public void GrabarLectura(LecturasDTO registroLectura)
        {
            try
            {
                using (var contexto = _contexto ?? new Modelo())
                {
                    // 1. Agregar el objeto Lectura
                    contexto.Lecturas.Add(registroLectura);

                    // 2. Guardar cambios (Dentro del ámbito de TransactionScope del Controlador)
                    contexto.SaveChanges();
                }
            }
            catch (DbEntityValidationException ex)
            {
                // Encapsula y lanza una excepción limpia
                throw new Exception("Error de validación de datos en el Modelo de Lectura.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error crítico de acceso a datos al guardar la Lectura.", ex);
            }
        }
    }
}