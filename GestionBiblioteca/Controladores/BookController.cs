using GestionBiblioteca.Modelos;

namespace GestionBiblioteca.Controladores
{
    public class BookController
    {
        private readonly LibroDAO libroDAO = new LibroDAO();

        // Método USADO PARA MODIFICACIÓN (llama al ActualizarLibroCompleto del DAO)        
        // Actualiza un libro y su lectura asociada.        
        public bool ActualizarLibro(LibroDTO libro, LecturasDTO lectura)
        {
            // Usa el método del DAO que maneja el EntityState.Modified
            return libroDAO.ActualizarLibro(libro, lectura);
        }

        // Método USADO PARA INSERCIÓN (necesario para el constructor por defecto del BookForm)      
        // Inserta un nuevo libro y devuelve su ID generado.        
        public int InsertarLibro(LibroDTO libro, LecturasDTO lectura)
        {
            // Usa el método del DAO que maneja la inserción con transacción y devuelve el ID
            return libroDAO.InsertarLibro(libro, lectura);
        }
    }
}