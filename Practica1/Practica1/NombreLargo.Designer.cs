namespace Practica1
{
    partial class NombreLargo
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
            this.listNLargo = new System.Windows.Forms.ListBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(238, 19);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(314, 29);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "NOMBRES MÁS LARGOS";
            // 
            // listNLargo
            // 
            this.listNLargo.FormattingEnabled = true;
            this.listNLargo.Location = new System.Drawing.Point(12, 68);
            this.listNLargo.Name = "listNLargo";
            this.listNLargo.Size = new System.Drawing.Size(776, 303);
            this.listNLargo.TabIndex = 4;
            this.listNLargo.SelectedIndexChanged += new System.EventHandler(this.listNLargo_SelectedIndexChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(351, 385);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(98, 44);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Volver";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // NombreLargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.listNLargo);
            this.Controls.Add(this.labelTitulo);
            this.Name = "NombreLargo";
            this.Text = "Los tres nombres mas largos";
            this.Load += new System.EventHandler(this.NombreLargo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.ListBox listNLargo;
        private System.Windows.Forms.Button buttonExit;
    }
}