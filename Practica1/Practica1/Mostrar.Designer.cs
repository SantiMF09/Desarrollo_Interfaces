namespace Practica1
{
    partial class Mostrar
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.listBoxRegistro = new System.Windows.Forms.ListBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(251, 47);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(325, 29);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "PERSONAS REGISTRDAS";
            // 
            // listBoxRegistro
            // 
            this.listBoxRegistro.FormattingEnabled = true;
            this.listBoxRegistro.Location = new System.Drawing.Point(12, 108);
            this.listBoxRegistro.Name = "listBoxRegistro";
            this.listBoxRegistro.Size = new System.Drawing.Size(776, 264);
            this.listBoxRegistro.TabIndex = 3;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(340, 393);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(118, 45);
            this.buttonVolver.TabIndex = 4;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // Mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.listBoxRegistro);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Mostrar";
            this.Text = "Mostrar Personas Insertadas";
            this.Load += new System.EventHandler(this.Mostrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.ListBox listBoxRegistro;
        private System.Windows.Forms.Button buttonVolver;
    }
}