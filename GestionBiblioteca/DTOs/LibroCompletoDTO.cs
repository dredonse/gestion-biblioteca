using GestionBiblioteca.Modelos;

namespace GestionBiblioteca.DTOs
{
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
