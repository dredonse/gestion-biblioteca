using GestionBiblioteca.DTOs;
using GestionBiblioteca.Modelos;
using System.Collections.Generic;

namespace GestionBiblioteca.Controladores
{
    public class BookListController
    {
        // El Controlador mantiene una referencia al DAO de la entidad principal
        private readonly LibroDAO libroDAO = new LibroDAO();

      
        // Obtiene la lista filtrada de libros delegando la tarea al DAO.      
        public List<LibroVistaDTO> ObtenerLibrosFiltrados(string autor,string editorial,string estado,string genero)
        {
            // Orquestación: el controlador simplemente pasa los parámetros al DAO.
            return libroDAO.ObtenerLibrosFiltrados(autor, editorial, estado, genero);
        }

        /// Intenta eliminar un libro y sus lecturas asociadas delegando la acción al DAO.
        /// <param name="idLibro">El ID del libro a eliminar.</param>
        public bool BorrarLibro(int idLibro)
        {
            // El controlador solo delega la eliminación al DAO y devuelve el resultado
            return libroDAO.EliminarLibro(idLibro);
        }

        /// Obtiene el DTO completo de un libro para pasarlo al formulario de edición.
        public LibroCompletoDTO ObtenerDatosLibroParaEdicion(int idLibro)
        {
            return libroDAO.ObtenerLibroPorId(idLibro);
        }       
    }
}