namespace Practica1
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
            this.InsertarPerson = new System.Windows.Forms.Button();
            this.ListadoPersonas = new System.Windows.Forms.Button();
            this.ConsultaDNI = new System.Windows.Forms.Button();
            this.NombreLargo = new System.Windows.Forms.Button();
            this.PersonasIncompletas = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InsertarPerson
            // 
            this.InsertarPerson.Location = new System.Drawing.Point(12, 104);
            this.InsertarPerson.Name = "InsertarPerson";
            this.InsertarPerson.Size = new System.Drawing.Size(249, 60);
            this.InsertarPerson.TabIndex = 0;
            this.InsertarPerson.Text = "INSERTAR UNA PERSONA";
            this.InsertarPerson.UseVisualStyleBackColor = true;
            this.InsertarPerson.Click += new System.EventHandler(this.InsertarPerson_Click);
            // 
            // ListadoPersonas
            // 
            this.ListadoPersonas.Location = new System.Drawing.Point(12, 170);
            this.ListadoPersonas.Name = "ListadoPersonas";
            this.ListadoPersonas.Size = new System.Drawing.Size(249, 60);
            this.ListadoPersonas.TabIndex = 1;
            this.ListadoPersonas.Text = "MOSTRAR LISTADO DE TODAS LAS PERSONAS";
            this.ListadoPersonas.UseVisualStyleBackColor = true;
            this.ListadoPersonas.Click += new System.EventHandler(this.ListadoPersonas_Click);
            // 
            // ConsultaDNI
            // 
            this.ConsultaDNI.Location = new System.Drawing.Point(267, 136);
            this.ConsultaDNI.Name = "ConsultaDNI";
            this.ConsultaDNI.Size = new System.Drawing.Size(249, 60);
            this.ConsultaDNI.TabIndex = 2;
            this.ConsultaDNI.Text = "CONSULTAR UNA PERSONA POR DNI";
            this.ConsultaDNI.UseVisualStyleBackColor = true;
            this.ConsultaDNI.Click += new System.EventHandler(this.ConsultaDNI_Click);
            // 
            // NombreLargo
            // 
            this.NombreLargo.Location = new System.Drawing.Point(522, 104);
            this.NombreLargo.Name = "NombreLargo";
            this.NombreLargo.Size = new System.Drawing.Size(249, 60);
            this.NombreLargo.TabIndex = 3;
            this.NombreLargo.Text = "MOSTRAR LAS 3 PERSONAS CON EL NOMBRE MÁS LARGO";
            this.NombreLargo.UseVisualStyleBackColor = true;
            this.NombreLargo.Click += new System.EventHandler(this.NombreLargo_Click);
            // 
            // PersonasIncompletas
            // 
            this.PersonasIncompletas.Location = new System.Drawing.Point(522, 170);
            this.PersonasIncompletas.Name = "PersonasIncompletas";
            this.PersonasIncompletas.Size = new System.Drawing.Size(249, 60);
            this.PersonasIncompletas.TabIndex = 4;
            this.PersonasIncompletas.Text = "MOSTRAR LAS PERSONAS QUE NO TENGAN TODOS LOS DATOS";
            this.PersonasIncompletas.UseVisualStyleBackColor = true;
            this.PersonasIncompletas.Click += new System.EventHandler(this.PersonasIncompletas_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(267, 346);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(249, 60);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "SALIR";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PersonasIncompletas);
            this.Controls.Add(this.NombreLargo);
            this.Controls.Add(this.ConsultaDNI);
            this.Controls.Add(this.ListadoPersonas);
            this.Controls.Add(this.InsertarPerson);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InsertarPerson;
        private System.Windows.Forms.Button ListadoPersonas;
        private System.Windows.Forms.Button ConsultaDNI;
        private System.Windows.Forms.Button NombreLargo;
        private System.Windows.Forms.Button PersonasIncompletas;
        private System.Windows.Forms.Button Exit;
    }
}

