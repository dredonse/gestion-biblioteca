namespace GestionBiblioteca.Vistas
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerBiblioteca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnadirNuevoLibro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerBiblioteca
            // 
            this.btnVerBiblioteca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVerBiblioteca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerBiblioteca.Location = new System.Drawing.Point(244, 425);
            this.btnVerBiblioteca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerBiblioteca.Name = "btnVerBiblioteca";
            this.btnVerBiblioteca.Size = new System.Drawing.Size(300, 77);
            this.btnVerBiblioteca.TabIndex = 0;
            this.btnVerBiblioteca.Text = "Ver mi biblioteca";
            this.btnVerBiblioteca.UseVisualStyleBackColor = true;
            this.btnVerBiblioteca.Click += new System.EventHandler(this.btnVerBiblioteca_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(294, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mi Biblioteca Personal";
            // 
            // btnAnadirNuevoLibro
            // 
            this.btnAnadirNuevoLibro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnadirNuevoLibro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirNuevoLibro.Location = new System.Drawing.Point(612, 425);
            this.btnAnadirNuevoLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnadirNuevoLibro.Name = "btnAnadirNuevoLibro";
            this.btnAnadirNuevoLibro.Size = new System.Drawing.Size(300, 77);
            this.btnAnadirNuevoLibro.TabIndex = 3;
            this.btnAnadirNuevoLibro.Text = "Añadir nuevo libro";
            this.btnAnadirNuevoLibro.UseVisualStyleBackColor = true;
            this.btnAnadirNuevoLibro.Click += new System.EventHandler(this.btnAnadirNuevoLibro_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnAnadirNuevoLibro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerBiblioteca);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Biblioteca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerBiblioteca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnadirNuevoLibro;
    }
}

