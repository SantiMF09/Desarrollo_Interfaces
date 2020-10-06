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
    public partial class Mostrar : Form
    {
        //creamos tambien la referencia en esta clase
        List<Persona> listaOriginal;
        public Mostrar()
        {
            InitializeComponent();
        }
        //Creamos una lista para comprarla con la original y no modificarla
        public Mostrar(List<Persona> LP)
        {
            listaOriginal = LP;

            InitializeComponent();
        }
        //un foreach que recorra todos los objetos de la lista y que muestre el toString creado en la clase Persona
        private void Mostrar_Load(object sender, EventArgs e)
        {
            foreach (Persona per in listaOriginal)
            {
                listBoxRegistro.Items.Add(per.ToString());
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}