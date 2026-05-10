using System.Drawing;

namespace GestionBiblioteca.Vistas
{
    partial class BookListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnAnadirNuevoLibro = new System.Windows.Forms.Button();
            this.tbxResena = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxEditorial = new System.Windows.Forms.TextBox();
            this.tbxAutor = new System.Windows.Forms.TextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.btnModificarLibro = new System.Windows.Forms.Button();
            this.btnBorrarLibro = new System.Windows.Forms.Button();
            this.dgvBiblioteca = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiblioteca)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(126, 133);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(171, 21);
            this.cbEstado.TabIndex = 26;
            // 
            // btnAnadirNuevoLibro
            // 
            this.btnAnadirNuevoLibro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirNuevoLibro.Location = new System.Drawing.Point(647, 68);
            this.btnAnadirNuevoLibro.Name = "btnAnadirNuevoLibro";
            this.btnAnadirNuevoLibro.Size = new System.Drawing.Size(130, 30);
            this.btnAnadirNuevoLibro.TabIndex = 25;
            this.btnAnadirNuevoLibro.Text = "Insertar Libro";
            this.btnAnadirNuevoLibro.UseVisualStyleBackColor = true;
            this.btnAnadirNuevoLibro.Click += new System.EventHandler(this.btnAnadirNuevoLibro_Click);
            // 
            // tbxResena
            // 
            this.tbxResena.Location = new System.Drawing.Point(382, 52);
            this.tbxResena.Multiline = true;
            this.tbxResena.Name = "tbxResena";
            this.tbxResena.ReadOnly = true;
            this.tbxResena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxResena.Size = new System.Drawing.Size(232, 192);
            this.tbxResena.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(379, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Comentario";
            // 
            // tbxEditorial
            // 
            this.tbxEditorial.Location = new System.Drawing.Point(126, 93);
            this.tbxEditorial.Name = "tbxEditorial";
            this.tbxEditorial.Size = new System.Drawing.Size(171, 20);
            this.tbxEditorial.TabIndex = 11;
            // 
            // tbxAutor
            // 
            this.tbxAutor.Location = new System.Drawing.Point(126, 53);
            this.tbxAutor.Name = "tbxAutor";
            this.tbxAutor.Size = new System.Drawing.Size(171, 20);
            this.tbxAutor.TabIndex = 13;
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(126, 174);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(171, 21);
            this.cbGenero.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Autor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(55, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Editorial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Género";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarLibro);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Location = new System.Drawing.Point(34, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 220);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLibro.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnBuscarLibro.Location = new System.Drawing.Point(113, 183);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(100, 30);
            this.btnBuscarLibro.TabIndex = 25;
            this.btnBuscarLibro.Text = "Buscar";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // btnModificarLibro
            // 
            this.btnModificarLibro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarLibro.Location = new System.Drawing.Point(647, 122);
            this.btnModificarLibro.Name = "btnModificarLibro";
            this.btnModificarLibro.Size = new System.Drawing.Size(130, 30);
            this.btnModificarLibro.TabIndex = 25;
            this.btnModificarLibro.Text = "Modificar Libro";
            this.btnModificarLibro.UseVisualStyleBackColor = true;
            this.btnModificarLibro.Click += new System.EventHandler(this.btnModificarLibro_Click);
            // 
            // btnBorrarLibro
            // 
            this.btnBorrarLibro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarLibro.Location = new System.Drawing.Point(647, 174);
            this.btnBorrarLibro.Name = "btnBorrarLibro";
            this.btnBorrarLibro.Size = new System.Drawing.Size(130, 30);
            this.btnBorrarLibro.TabIndex = 25;
            this.btnBorrarLibro.Text = "Borrar Libro";
            this.btnBorrarLibro.UseVisualStyleBackColor = true;
            this.btnBorrarLibro.Click += new System.EventHandler(this.btnBorrarLibro_Click);
            // 
            // dgvBiblioteca
            // 
            this.dgvBiblioteca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBiblioteca.Location = new System.Drawing.Point(34, 265);
            this.dgvBiblioteca.Name = "dgvBiblioteca";
            this.dgvBiblioteca.ReadOnly = true;
            this.dgvBiblioteca.RowHeadersWidth = 25;
            this.dgvBiblioteca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBiblioteca.Size = new System.Drawing.Size(743, 173);
            this.dgvBiblioteca.TabIndex = 29;
            this.dgvBiblioteca.SelectionChanged += new System.EventHandler(this.dgvBiblioteca_SelectionChanged);
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBiblioteca);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.btnBorrarLibro);
            this.Controls.Add(this.btnModificarLibro);
            this.Controls.Add(this.btnAnadirNuevoLibro);
            this.Controls.Add(this.tbxResena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxEditorial);
            this.Controls.Add(this.tbxAutor);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookListForm";
            this.Load += new System.EventHandler(this.BookListForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiblioteca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxEditorial;
        private System.Windows.Forms.TextBox tbxAutor;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.Button btnModificarLibro;
        private System.Windows.Forms.Button btnBorrarLibro;
        private System.Windows.Forms.DataGridView dgvBiblioteca;
        public System.Windows.Forms.Button btnAnadirNuevoLibro;
        private System.Windows.Forms.TextBox tbxResena;
    }
}