using System.Windows.Forms;

namespace GestionBiblioteca.Vistas
{
    public partial class MainForm : Form
    {
        private BookListForm biblioteca;

        public MainForm()
        {
            InitializeComponent();            
        }

        private void btnVerBiblioteca_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            biblioteca = new BookListForm();
            biblioteca.Show();
        }

    }
}