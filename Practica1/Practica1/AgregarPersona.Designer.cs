namespace Practica1
{
    partial class AgregarPersona
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
            this.LabelNombre = new System.Windows.Forms.Label();
            this.LabelApellido = new System.Windows.Forms.Label();
            this.LabelDNI = new System.Windows.Forms.Label();
            this.LabelNacimento = new System.Windows.Forms.Label();
            this.LabelPeso = new System.Windows.Forms.Label();
            this.LabelAltura = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textPeso = new System.Windows.Forms.TextBox();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.textAlttura = new System.Windows.Forms.TextBox();
            this.dateNacimento = new System.Windows.Forms.DateTimePicker();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombre.Location = new System.Drawing.Point(145, 105);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(65, 20);
            this.LabelNombre.TabIndex = 0;
            this.LabelNombre.Text = "Nombre";
            // 
            // LabelApellido
            // 
            this.LabelApellido.AutoSize = true;
            this.LabelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApellido.Location = new System.Drawing.Point(137, 146);
            this.LabelApellido.Name = "LabelApellido";
            this.LabelApellido.Size = new System.Drawing.Size(73, 20);
            this.LabelApellido.TabIndex = 1;
            this.LabelApellido.Text = "Apellidos";
            // 
            // LabelDNI
            // 
            this.LabelDNI.AutoSize = true;
            this.LabelDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDNI.Location = new System.Drawing.Point(173, 66);
            this.LabelDNI.Name = "LabelDNI";
            this.LabelDNI.Size = new System.Drawing.Size(37, 20);
            this.LabelDNI.TabIndex = 2;
            this.LabelDNI.Text = "DNI";
            this.LabelDNI.Click += new System.EventHandler(this.LabelDNI_Click);
            // 
            // LabelNacimento
            // 
            this.LabelNacimento.AutoSize = true;
            this.LabelNacimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNacimento.Location = new System.Drawing.Point(122, 265);
            this.LabelNacimento.Name = "LabelNacimento";
            this.LabelNacimento.Size = new System.Drawing.Size(88, 40);
            this.LabelNacimento.TabIndex = 3;
            this.LabelNacimento.Text = "Fecha de \r\nNacimiento";
            this.LabelNacimento.Click += new System.EventHandler(this.LabelNacimento_Click);
            // 
            // LabelPeso
            // 
            this.LabelPeso.AutoSize = true;
            this.LabelPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPeso.Location = new System.Drawing.Point(165, 230);
            this.LabelPeso.Name = "LabelPeso";
            this.LabelPeso.Size = new System.Drawing.Size(45, 20);
            this.LabelPeso.TabIndex = 4;
            this.LabelPeso.Text = "Peso";
            // 
            // LabelAltura
            // 
            this.LabelAltura.AutoSize = true;
            this.LabelAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAltura.Location = new System.Drawing.Point(160, 189);
            this.LabelAltura.Name = "LabelAltura";
            this.LabelAltura.Size = new System.Drawing.Size(51, 20);
            this.LabelAltura.TabIndex = 5;
            this.LabelAltura.Text = "Altura";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(216, 107);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 6;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(216, 148);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(100, 20);
            this.textApellido.TabIndex = 7;
            this.textApellido.TextChanged += new System.EventHandler(this.textApellido_TextChanged);
            // 
            // textPeso
            // 
            this.textPeso.Location = new System.Drawing.Point(216, 232);
            this.textPeso.Name = "textPeso";
            this.textPeso.Size = new System.Drawing.Size(100, 20);
            this.textPeso.TabIndex = 8;
            this.textPeso.TextChanged += new System.EventHandler(this.textPeso_TextChanged);
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(216, 66);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(100, 20);
            this.textDNI.TabIndex = 9;
            this.textDNI.TextChanged += new System.EventHandler(this.textDNI_TextChanged);
            // 
            // textAlttura
            // 
            this.textAlttura.Location = new System.Drawing.Point(216, 191);
            this.textAlttura.Name = "textAlttura";
            this.textAlttura.Size = new System.Drawing.Size(100, 20);
            this.textAlttura.TabIndex = 10;
            this.textAlttura.TextChanged += new System.EventHandler(this.textAlttura_TextChanged);
            // 
            // dateNacimento
            // 
            this.dateNacimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNacimento.Location = new System.Drawing.Point(216, 274);
            this.dateNacimento.Name = "dateNacimento";
            this.dateNacimento.Size = new System.Drawing.Size(100, 20);
            this.dateNacimento.TabIndex = 11;
            this.dateNacimento.ValueChanged += new System.EventHandler(this.dateNacimento_ValueChanged);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(84, 24);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(280, 29);
            this.labelTitulo.TabIndex = 12;
            this.labelTitulo.Text = "DATOS PERSONALES";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(164, 327);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(121, 35);
            this.buttonSend.TabIndex = 13;
            this.buttonSend.Text = "Enviar";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(347, 384);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(98, 24);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Volver";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // AgregarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 420);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.dateNacimento);
            this.Controls.Add(this.textAlttura);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.textPeso);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.LabelAltura);
            this.Controls.Add(this.LabelPeso);
            this.Controls.Add(this.LabelNacimento);
            this.Controls.Add(this.LabelDNI);
            this.Controls.Add(this.LabelApellido);
            this.Controls.Add(this.LabelNombre);
            this.Name = "AgregarPersona";
            this.Text = "Insertar Personas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Label LabelApellido;
        private System.Windows.Forms.Label LabelDNI;
        private System.Windows.Forms.Label LabelNacimento;
        private System.Windows.Forms.Label LabelPeso;
        private System.Windows.Forms.Label LabelAltura;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textPeso;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.TextBox textAlttura;
        private System.Windows.Forms.DateTimePicker dateNacimento;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonExit;
    }
}