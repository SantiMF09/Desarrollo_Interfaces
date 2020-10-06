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
    public partial class NombreLargo : Form
    {
        //creamos tambien la referencia en esta clase
        List<Persona> listaOriginal;
        public NombreLargo()
        {
            InitializeComponent();
        }
        //Creamos una lista para comprarla con la original y no modificarla
        public NombreLargo(List<Persona> LP)
        {
            listaOriginal = LP;
            InitializeComponent();
        }

        private void listNLargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NombreLargo_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcion se esta desarrollando.\n Disculpe las molestias");
        }
    }
}