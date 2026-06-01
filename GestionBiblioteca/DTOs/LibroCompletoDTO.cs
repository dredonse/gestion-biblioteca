using GestionBiblioteca.Modelos;

namespace GestionBiblioteca.DTOs
{
    // Autor: David Redondo Serrano
    // Fecha: Mayo 2026
    // Descripción: DTO que agrupa libro y lectura para el formulario de edición.
    /// DTO auxiliar utilizado para transferir un libro y su lectura asociada
    /// desde el DAO al formulario de edición (BookForm).
    public class LibroCompletoDTO
    {
        // Contiene todos los datos del libro
        public LibroDTO Libro
        {
            get; set;
        }

        // Contiene todos los datos de la lectura asociada
        public LecturasDTO Lectura
        {
            get; set;
        }
    }
}
