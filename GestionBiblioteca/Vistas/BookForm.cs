using GestionBiblioteca.Modelos;
using System;
using System.Windows.Forms;
using GestionBiblioteca.Controladores;

namespace GestionBiblioteca.Vistas
{
    public partial class BookForm : Form
    {
        // Campos privados para mantener la referencia a los objetos DTO originales.
        private LibroDTO libroActual;
        private LecturasDTO lecturaActual;
        private BookController controlador; // Se usará para llamar directamente a GuardarLibro

        // =========================================================================
        // CONSTRUCTORES
        // =========================================================================

        // Constructor usado para INSERTAR un libro nuevo.    
        public BookForm()
        {
            InitializeComponent();
            controlador = new BookController(); // Inicializar para Inserción
            CargarCombos();
            this.Text = "Nuevo Libro";
        }
      
        // Constructor usado para MODIFICAR un libro existente.       
        public BookForm(LibroDTO libro, LecturasDTO lectura)
        {
            InitializeComponent();
            CargarCombos();
            this.Text = "Modificar Libro Existente";

            libroActual = libro;
            lecturaActual = lectura;
            controlador = new BookController(); // Inicialización para Modificación

            CargarDatosEnControles();
        }

        // =========================================================================
        // MÉTODOS DE LA VISTA
        // =========================================================================
        private void CargarDatosEnControles()
        {
            if (libroActual == null || lecturaActual == null) return;

            // Datos del Libro (LibroDTO)
            this.tbxTitulo.Text = libroActual.Titulo;
            this.tbxAutor.Text = libroActual.Autor;
            this.tbxEditorial.Text = libroActual.Editorial;
            this.cbGenero.Text = libroActual.Genero;
            this.tbxIdioma.Text = libroActual.Idioma;

            // Asignación segura de DateTime? a string
            this.tbxFechaPub.Text = libroActual.FechaPublicacion.GetValueOrDefault(DateTime.Today).ToShortDateString();

            // Datos de la Lectura (LecturasDTO)
            this.cbEstado.Text = lecturaActual.Estado;
            this.nudLecturas.Value = (decimal)lecturaActual.NumeroLectura;
            this.tbxComentario.Text = lecturaActual.Comentario;
        }     
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Si estamos en modo Modificación, libroActual no es nulo
                bool esModificacion = (libroActual != null);

                // Si es un nuevo registro, inicializamos los DTOs
                if (!esModificacion)
                {
                    libroActual = new LibroDTO();
                    lecturaActual = new LecturasDTO();
                }

                // Recoger los datos de los controles y ASIGNARLOS A LOS OBJETOS DTO
                libroActual.Titulo = this.tbxTitulo.Text.Trim();
                libroActual.Autor = this.tbxAutor.Text.Trim();
                libroActual.Editorial = this.tbxEditorial.Text.Trim();
                libroActual.Genero = this.cbGenero.Text;
                libroActual.Idioma = this.tbxIdioma.Text.Trim();

                // Conversión segura y concisa de STRING a DATETIME?
                DateTime fechaTemporal;
                libroActual.FechaPublicacion =
                    DateTime.TryParse(this.tbxFechaPub.Text.Trim(), out fechaTemporal)
                    ? fechaTemporal
                    : (DateTime?)null; // Asigna null si es inválido o vacío. El DTO lanzará error si es obligatorio.

                // Datos de Lectura
                lecturaActual.Estado = this.cbEstado.Text;
                lecturaActual.Comentario = this.tbxComentario.Text.Trim();
                lecturaActual.NumeroLectura = (int)this.nudLecturas.Value;


                // Llamar al controlador para guardar/actualizar
                bool exito;
                int idRecibido = 0;

                if (esModificacion)
                {
                    // Llama al método que actualiza (ActualizarLibroCompleto en el DAO)
                    exito = controlador.ActualizarLibro(libroActual, lecturaActual);
                }
                else
                {
                    // Llama al método que inserta (GuardarLibro en el DAO)
                    idRecibido = controlador.InsertarLibro(libroActual, lecturaActual);
                    exito = (idRecibido > 0);
                }

                if (exito)
                {
                    mostrarMensaje("Libro procesado exitosamente.", MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    mostrarMensaje("No se realizaron cambios en el libro.", MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                string mensajeUsuario = ObtenerMensajeErrorValidacion(ex.Message)
                    ?? "Error al guardar el libro: " + ex.Message;
                MessageBox.Show(mensajeUsuario, "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Mensajes para las claves que lanzan los setters de <see cref="LibroDTO"/> en Modelo.cs.
        /// </summary>
        private static string ObtenerMensajeErrorValidacion(string error)
        {
            if (string.IsNullOrWhiteSpace(error))
                return null;

            switch (error.Trim())
            {
                case "ErrorTitulo":
                    return "El título es obligatorio y no puede estar vacío.";
                case "ErrorAutorVacio":
                    return "El autor es obligatorio y no puede estar vacío.";
                case "ErrorEditorial":
                    return "La editorial es obligatoria y no puede estar vacía.";
                case "ErrorGenero":
                    return "El género es obligatorio y no puede estar vacío.";
                case "ErrorIdioma":
                    return "El idioma es obligatorio y no puede estar vacío.";
                case "ErrorFechaPublicacionInvalida":
                    return "La fecha de publicación es obligatoria, debe ser válida y no puede ser posterior a hoy.";
                default:
                    return null;
            }
        }
        private void btnVolverABiblioteca_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarCombos()
        {
            string[] generos = new string[] { "Ficción", "Novela Histórica", "Ciencia Ficción", "Fantasía", "Misterio/Thriller", "Biografía", "Ensayo", "Poesía" };
            string[] estadosLectura = new string[] { "Pendiente", "En Progreso", "Completado", "Abandonado" };
            cbGenero.Items.AddRange(generos);
            cbEstado.Items.AddRange(estadosLectura);
            cbGenero.SelectedItem = "Ficción";
            cbEstado.SelectedItem = "Pendiente";
        }
        private void mostrarMensaje(string texto, MessageBoxIcon icon = MessageBoxIcon.Error)
        {
            MessageBox.Show(texto, "Mensaje de la Aplicación", MessageBoxButtons.OK, icon);
        }

        private void BookForm_Load(object sender, EventArgs e)
        {

        }
    }
}