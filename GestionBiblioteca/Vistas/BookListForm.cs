using GestionBiblioteca.Controladores;
using GestionBiblioteca.DTOs;
using GestionBiblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionBiblioteca.Vistas
{
    // Autor: David Redondo Serrano
    // Fecha: Mayo 2026
    // Descripción: Formulario principal de listado y gestión del catálogo de libros.
    public partial class BookListForm: Form
    {
        private readonly BookListController controlador = new BookListController();

        private BookForm bookForm;

        public BookListForm()
        {
            InitializeComponent();
            CargarCombos();
        }

        private void CargarCombos()
        {
            // Cargar Géneros (ComboBox: cbGenero)
            // Estos son valores de negocio para la tabla Libros.
            string[] generos = new string[]
            {
                "Ficción",
                "Novela Histórica",
                "Ciencia Ficción",
                "Fantasía",
                "Misterio/Thriller",
                "Biografía",
                "Ensayo",
                "Poesía"
            };
            cbGenero.Items.AddRange(generos);

            // Cargar Estados (ComboBox: cbEstado)
            // Estos son valores de negocio para la tabla Lecturas.
            string[] estadosLectura = new string[]
            {
                "Pendiente",
                "En Progreso",
                "Completado",
                "Abandonado"
            };
            cbEstado.Items.AddRange(estadosLectura);

            // cbEstado.SelectedItem = "Pendiente";
        }

        private void btnAnadirNuevoLibro_Click(object sender, EventArgs e)
        {
            bookForm = new BookForm();
            if (bookForm.ShowDialog() == DialogResult.OK)
                CargarDatosEnDataGridView();
        }

        private void btnModificarLibro_Click(object sender, EventArgs e)
        {
            // Verificar selección
            if (dgvBiblioteca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un libro para poder modificarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID del libro seleccionado (desde el DTO de la Vista)
            LibroVistaDTO libroSeleccionado = dgvBiblioteca.SelectedRows[0].DataBoundItem as LibroVistaDTO;
            int idLibroAEditar = libroSeleccionado.IdLibro;

            try
            {
                // Obtener los datos completos del libro del controlador
                LibroCompletoDTO datosCompletos = controlador.ObtenerDatosLibroParaEdicion(idLibroAEditar);

                if (datosCompletos != null)
                {
                    // Crear e instanciar el formulario de edición, pasándole los DTOs completos
                    using (var bookForm = new BookForm(datosCompletos.Libro, datosCompletos.Lectura))
                    {
                        // Mostrar el formulario y verificar si hubo actualización (DialogResult.OK)
                        if (bookForm.ShowDialog() == DialogResult.OK)
                        {
                            // Si el BookForm devolvió OK, significa que se guardaron los cambios.
                            // Recargar la lista para mostrar la modificación.
                            CargarDatosEnDataGridView();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron los datos completos del libro.", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void btnBorrarLibro_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dgvBiblioteca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un libro para poder borrarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el DTO de la fila seleccionada y su ID
            LibroVistaDTO libroSeleccionado = dgvBiblioteca.SelectedRows[0].DataBoundItem as LibroVistaDTO;

            // Verificación de seguridad
            if (libroSeleccionado == null)
            {
                MessageBox.Show("Error al obtener los datos del libro seleccionado.", "Error Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idLibroABorrar = libroSeleccionado.IdLibro;

            // Pedir confirmación al usuario
            DialogResult resultado = MessageBox.Show(
                $"¿Está seguro de que desea borrar el libro '{libroSeleccionado.Título}' (ID: {idLibroABorrar})? Esta acción eliminará todas sus lecturas asociadas.",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    // Llamar al Controlador para ejecutar la eliminación
                    bool exito = controlador.BorrarLibro(idLibroABorrar);

                    if (exito)
                    {
                        MessageBox.Show("Libro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar el DataGridView para actualizar la lista
                        CargarDatosEnDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar el libro para eliminar. Verifique el estado de la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al intentar borrar el libro: " + ex.Message, "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            tbxAutor.Text = string.Empty;
            tbxEditorial.Text = string.Empty;
            cbEstado.SelectedIndex = -1;
            cbGenero.SelectedIndex = -1;
            CargarDatosEnDataGridView();
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            // Recoger los valores de los controles
            string autor = tbxAutor.Text.Trim();
            string editorial = tbxEditorial.Text.Trim();
            string estado = cbEstado.Text;
            string genero = cbGenero.Text;

            // Llamar al método de carga de datos con los filtros
            CargarDatosEnDataGridView(autor, editorial, estado, genero);
        }

        private void BookListForm_Load(object sender, EventArgs e)
        {
            CargarDatosEnDataGridView();
        }

        // Método que llama al Controlador para obtener los datos
        public void CargarDatosEnDataGridView(string autor = null, string editorial = null, string estado = null, string genero = null)
        {
            try
            {
                List<LibroVistaDTO> datosLibros;

                // Siempre llamamos al método filtrado con los parámetros (que serán nulls o vacíos en la carga inicial)
                datosLibros = controlador.ObtenerLibrosFiltrados(autor, editorial, estado, genero);

                dgvBiblioteca.DataSource = null;
                dgvBiblioteca.DataSource = datosLibros;
                AjustarColumnasDataGridView();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al cargar los datos del catálogo: " + ex.Message,
                    "Error al cargar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AjustarColumnasDataGridView()
        {
            // OCULTAR COLUMNA IDLIBRO
            if (dgvBiblioteca.Columns.Contains("IdLibro"))
            {
                // Ocultar la columna IdLibro, ya que es un campo de control interno
                dgvBiblioteca.Columns["IdLibro"].Visible = false;
            }

            // Ocultar la columna Comentario (que se muestra en el TextBox)
            if (dgvBiblioteca.Columns.Contains("Comentario"))
            {
                dgvBiblioteca.Columns["Comentario"].Visible = false;
            }

            if (dgvBiblioteca.Columns.Contains("Fecha_Publicación"))
            {
                dgvBiblioteca.Columns["Fecha_Publicación"].HeaderText = "Fecha Publicación";
                // dgvBiblioteca.Columns["Fecha_Publicación"].MinimumWidth = 120;
            }
            if (dgvBiblioteca.Columns.Contains("EstadoActual"))
            {
                dgvBiblioteca.Columns["EstadoActual"].HeaderText = "Estado Actual";
            }
            if (dgvBiblioteca.Columns.Contains("Número_Lectura"))
            {
                dgvBiblioteca.Columns["Número_Lectura"].HeaderText = "Número de Lectura";
            }

            dgvBiblioteca.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        // Manejador de eventos que se dispara cuando la selección de fila cambia.
        // Muestra el comentario de la fila seleccionada en el TextBox de Reseña.        
        private void dgvBiblioteca_SelectionChanged(object sender, System.EventArgs e)
        {
            // Verificar que hay al menos una fila seleccionada
            if (dgvBiblioteca.SelectedRows.Count > 0)
            {
                // Obtener la primera fila seleccionada (solo la primera si hay múltiples)
                DataGridViewRow filaSeleccionada = dgvBiblioteca.SelectedRows[0];

                // Obtener el objeto DTO subyacente que está enlazado a esa fila.
                // El DataBoundItem es un objeto de tipo LibroVistaDTO.
                LibroVistaDTO libroSeleccionado = filaSeleccionada.DataBoundItem as LibroVistaDTO;

                if (libroSeleccionado != null)
                {
                    // Acceder a la propiedad 'Comentario' del DTO y asignarla al TextBox.
                    // Usamos el operador de coalescencia nula (??) para asegurar que no sea null.
                    this.tbxResena.Text = libroSeleccionado.Comentario ?? string.Empty;
                }
            }
            else
            {
                // Si no hay filas seleccionadas (o la selección se limpió), limpiar el TextBox.
                this.tbxResena.Text = string.Empty;
            }
        }

      
    }
}