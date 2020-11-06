using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class AgregarPersona : Form
    {
       
        public AgregarPersona()
        {
            InitializeComponent();
        }
        //creamos tambien la referencia en esta clase
        List<Persona> listaOriginal;
        //Creamos una lista para comprarla con la original y no modificarla
        public AgregarPersona(List<Persona> LP)
        {
            listaOriginal = LP;

            InitializeComponent();
        }
        //para que muestre los campos vacios los int deben tener algun valor, en este caso es el 0.
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textAlttura.Text))
            {
                textAlttura.Text = "0";
            }
            if (String.IsNullOrEmpty(textPeso.Text))
            {
                textPeso.Text = "0";
            }
            //Aquí añadimos los valores a cada persona, creando un nuevo objeto cada vez que se quiera.
            listaOriginal.Add(new Persona(textDNI.Text, textNombre.Text, textApellido.Text, Double.Parse(textAlttura.Text), Double.Parse(textPeso.Text), dateNacimento.Value));

            Persona p = new Persona();
            
            //esto es para q se limpie la pantalla y el formulario este vacio.
            textAlttura.Clear(); textDNI.Clear(); textApellido.Clear(); textPeso.Clear(); textNombre.Clear(); 
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateNacimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAlttura_TextChanged(object sender, EventArgs e)
        {

        }
        //para salir del formulario
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LabelDNI_Click(object sender, EventArgs e)
        {

        }

        private void LabelNacimento_Click(object sender, EventArgs e)
        {

        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}