using System.Drawing;

namespace GestionBiblioteca.Vistas
{
    partial class BookForm
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
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFechaPub = new System.Windows.Forms.TextBox();
            this.tbxEditorial = new System.Windows.Forms.TextBox();
            this.tbxIdioma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxComentario = new System.Windows.Forms.TextBox();
            this.btnVolverABiblioteca = new System.Windows.Forms.Button();
            this.btnGuardarLibro = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.nudLecturas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudLecturas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTitulo.Location = new System.Drawing.Point(48, 120);
            this.tbxTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(254, 30);
            this.tbxTitulo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Título";
            // 
            // tbxAutor
            // 
            this.tbxAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAutor.Location = new System.Drawing.Point(48, 234);
            this.tbxAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxAutor.Name = "tbxAutor";
            this.tbxAutor.Size = new System.Drawing.Size(238, 30);
            this.tbxAutor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(372, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Género";
            // 
            // tbxFechaPub
            // 
            this.tbxFechaPub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFechaPub.Location = new System.Drawing.Point(372, 120);
            this.tbxFechaPub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxFechaPub.Name = "tbxFechaPub";
            this.tbxFechaPub.Size = new System.Drawing.Size(266, 30);
            this.tbxFechaPub.TabIndex = 5;
            // 
            // tbxEditorial
            // 
            this.tbxEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEditorial.Location = new System.Drawing.Point(48, 478);
            this.tbxEditorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxEditorial.Name = "tbxEditorial";
            this.tbxEditorial.Size = new System.Drawing.Size(238, 30);
            this.tbxEditorial.TabIndex = 4;
            // 
            // tbxIdioma
            // 
            this.tbxIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIdioma.Location = new System.Drawing.Point(372, 234);
            this.tbxIdioma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxIdioma.Name = "tbxIdioma";
            this.tbxIdioma.Size = new System.Drawing.Size(254, 30);
            this.tbxIdioma.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(372, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha Publicación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(48, 432);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Editorial";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(372, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Idioma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(372, 432);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Número Lecturas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(687, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Comentario";
            // 
            // tbxComentario
            // 
            this.tbxComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxComentario.Location = new System.Drawing.Point(692, 122);
            this.tbxComentario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxComentario.Multiline = true;
            this.tbxComentario.Name = "tbxComentario";
            this.tbxComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxComentario.Size = new System.Drawing.Size(468, 386);
            this.tbxComentario.TabIndex = 9;
            // 
            // btnVolverABiblioteca
            // 
            this.btnVolverABiblioteca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverABiblioteca.Location = new System.Drawing.Point(624, 588);
            this.btnVolverABiblioteca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolverABiblioteca.Name = "btnVolverABiblioteca";
            this.btnVolverABiblioteca.Size = new System.Drawing.Size(246, 46);
            this.btnVolverABiblioteca.TabIndex = 11;
            this.btnVolverABiblioteca.Text = "Volver a Biblioteca";
            this.btnVolverABiblioteca.UseVisualStyleBackColor = true;
            this.btnVolverABiblioteca.Click += new System.EventHandler(this.btnVolverABiblioteca_Click);
            // 
            // btnGuardarLibro
            // 
            this.btnGuardarLibro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarLibro.Location = new System.Drawing.Point(333, 588);
            this.btnGuardarLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarLibro.Name = "btnGuardarLibro";
            this.btnGuardarLibro.Size = new System.Drawing.Size(246, 46);
            this.btnGuardarLibro.TabIndex = 10;
            this.btnGuardarLibro.Text = "Guardar Libro";
            this.btnGuardarLibro.UseVisualStyleBackColor = true;
            this.btnGuardarLibro.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(372, 357);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(254, 33);
            this.cbEstado.TabIndex = 7;
            // 
            // cbGenero
            // 
            this.cbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(48, 357);
            this.cbGenero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(254, 33);
            this.cbGenero.TabIndex = 3;
            // 
            // nudLecturas
            // 
            this.nudLecturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLecturas.Location = new System.Drawing.Point(372, 478);
            this.nudLecturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudLecturas.Name = "nudLecturas";
            this.nudLecturas.Size = new System.Drawing.Size(254, 30);
            this.nudLecturas.TabIndex = 8;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.nudLecturas);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.btnGuardarLibro);
            this.Controls.Add(this.btnVolverABiblioteca);
            this.Controls.Add(this.tbxComentario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxIdioma);
            this.Controls.Add(this.tbxEditorial);
            this.Controls.Add(this.tbxFechaPub);
            this.Controls.Add(this.tbxAutor);
            this.Controls.Add(this.tbxTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLecturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxFechaPub;
        private System.Windows.Forms.TextBox tbxEditorial;
        private System.Windows.Forms.TextBox tbxIdioma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardarLibro;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.NumericUpDown nudLecturas;
        public System.Windows.Forms.Button btnVolverABiblioteca;
        private System.Windows.Forms.TextBox tbxComentario;
    }
}