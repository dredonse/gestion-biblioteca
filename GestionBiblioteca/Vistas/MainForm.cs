using System.Windows.Forms;

namespace GestionBiblioteca.Vistas
{
    public partial class MainForm : Form
    {
        private BookListForm biblioteca;
        private BookForm formularioLibro;

        public MainForm()
        {
            InitializeComponent();            
        }

        private void btnVerBiblioteca_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            biblioteca = new BookListForm();
            biblioteca.ShowDialog();
            this.Close();
        }

        private void btnAnadirNuevoLibro_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            formularioLibro = new BookForm();
            formularioLibro.ShowDialog();
            this.Close();
        }
    }
}