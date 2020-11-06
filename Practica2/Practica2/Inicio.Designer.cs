namespace Practica2
{
    partial class Inicio
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
            this.buttonNewAgenda = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonViewAgenda = new System.Windows.Forms.Button();
            this.buttonCTarea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewAgenda
            // 
            this.buttonNewAgenda.Location = new System.Drawing.Point(12, 105);
            this.buttonNewAgenda.Name = "buttonNewAgenda";
            this.buttonNewAgenda.Size = new System.Drawing.Size(149, 82);
            this.buttonNewAgenda.TabIndex = 0;
            this.buttonNewAgenda.Text = "Crear Agendas";
            this.buttonNewAgenda.UseVisualStyleBackColor = true;
            this.buttonNewAgenda.Click += new System.EventHandler(this.buttonNewAgenda_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(217, 256);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(188, 83);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonViewAgenda
            // 
            this.buttonViewAgenda.Location = new System.Drawing.Point(227, 105);
            this.buttonViewAgenda.Name = "buttonViewAgenda";
            this.buttonViewAgenda.Size = new System.Drawing.Size(169, 82);
            this.buttonViewAgenda.TabIndex = 7;
            this.buttonViewAgenda.Text = "Ver Agendas";
            this.buttonViewAgenda.UseVisualStyleBackColor = true;
            this.buttonViewAgenda.Click += new System.EventHandler(this.buttonViewAgenda_Click);
            // 
            // buttonCTarea
            // 
            this.buttonCTarea.Location = new System.Drawing.Point(445, 105);
            this.buttonCTarea.Name = "buttonCTarea";
            this.buttonCTarea.Size = new System.Drawing.Size(169, 82);
            this.buttonCTarea.TabIndex = 8;
            this.buttonCTarea.Text = "Crear Tareas";
            this.buttonCTarea.UseVisualStyleBackColor = true;
            this.buttonCTarea.Click += new System.EventHandler(this.buttonCTarea_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 364);
            this.Controls.Add(this.buttonCTarea);
            this.Controls.Add(this.buttonViewAgenda);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonNewAgenda);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewAgenda;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonViewAgenda;
        private System.Windows.Forms.Button buttonCTarea;
    }
}

