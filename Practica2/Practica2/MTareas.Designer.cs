namespace Practica2
{
    partial class MTareas
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
            this.buttonDeleteTarea = new System.Windows.Forms.Button();
            this.buttonNewTarea = new System.Windows.Forms.Button();
            this.buttonModfTarea = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDeleteTarea
            // 
            this.buttonDeleteTarea.Location = new System.Drawing.Point(529, 89);
            this.buttonDeleteTarea.Name = "buttonDeleteTarea";
            this.buttonDeleteTarea.Size = new System.Drawing.Size(190, 85);
            this.buttonDeleteTarea.TabIndex = 7;
            this.buttonDeleteTarea.Text = "Borrar Tarea";
            this.buttonDeleteTarea.UseVisualStyleBackColor = true;
            this.buttonDeleteTarea.Click += new System.EventHandler(this.buttonDeleteTarea_Click);
            // 
            // buttonNewTarea
            // 
            this.buttonNewTarea.Location = new System.Drawing.Point(282, 89);
            this.buttonNewTarea.Name = "buttonNewTarea";
            this.buttonNewTarea.Size = new System.Drawing.Size(190, 85);
            this.buttonNewTarea.TabIndex = 6;
            this.buttonNewTarea.Text = "Nueva Tarea";
            this.buttonNewTarea.UseVisualStyleBackColor = true;
            this.buttonNewTarea.Click += new System.EventHandler(this.buttonNewTarea_Click);
            // 
            // buttonModfTarea
            // 
            this.buttonModfTarea.Location = new System.Drawing.Point(42, 89);
            this.buttonModfTarea.Name = "buttonModfTarea";
            this.buttonModfTarea.Size = new System.Drawing.Size(190, 85);
            this.buttonModfTarea.TabIndex = 9;
            this.buttonModfTarea.Text = "Modificar Tarea";
            this.buttonModfTarea.UseVisualStyleBackColor = true;
            this.buttonModfTarea.Click += new System.EventHandler(this.buttonModfTarea_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(284, 294);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(188, 83);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // MTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 440);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonModfTarea);
            this.Controls.Add(this.buttonDeleteTarea);
            this.Controls.Add(this.buttonNewTarea);
            this.Name = "MTareas";
            this.Text = "MTareas";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDeleteTarea;
        private System.Windows.Forms.Button buttonNewTarea;
        private System.Windows.Forms.Button buttonModfTarea;
        private System.Windows.Forms.Button buttonBack;
    }
}