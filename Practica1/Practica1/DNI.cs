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
    public partial class DNI : Form
    {
        //creamos tambien la referencia en esta clase
        List<Persona> listaOriginal;
        public DNI()
        {
            InitializeComponent();
        }
        //Creamos una lista para comprarla con la original y no modificarla
        public DNI(List<Persona> LP)
        {
            listaOriginal = LP;
            InitializeComponent();
        }

        private void textSearchDNI_TextChanged(object sender, EventArgs e)
        {
            
        }
        //un primer foreach que recorra la lista donde se encuentra los objetos
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            foreach (Persona p in listaOriginal) 
            {
                //un boleano para saber si el DNI existe o esta erroneo
                Boolean check=false;
                if (textSearchDNI.Text == p.DNI1)
                {
                     check=true;
                }
                else
                {
                    check = false;
                }
                //en caso de que si exista muestras el toString
                if (check==true)
                {
                    MessageBox.Show(p.ToString());
                    break;
                }
                //en caso contrario muestra un mensaje que diga DNI incorrecto
                if(check=false)
                {
                    MessageBox.Show("DNI incorrecto");
                }
            }
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}