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
    public partial class Inicio : Form
    {
        /*Creamos una lista de tipo persona(la clase creada), con el nombre de listaOriginal. 
        Esto lo utilazaremos para refenciar los objetos en diferentes formularios*/
        List<Persona> listaOriginal=new List<Persona>();
        public Inicio()
        {
            InitializeComponent();
        }
        /*Creamos la referencia de la lista en el formulario, y que al clicar muestre el formulario referenciado
        Así con todos los formularios*/
        private void InsertarPerson_Click(object sender, EventArgs e)
        {
            AgregarPersona f2 = new AgregarPersona(listaOriginal);
            f2.Show();
        }

        private void ListadoPersonas_Click(object sender, EventArgs e)
        {
            Mostrar f3 = new Mostrar(listaOriginal);
            f3.Show();
        }

        private void ConsultaDNI_Click(object sender, EventArgs e)
        {
            DNI f4 = new DNI(listaOriginal);
            f4.Show();
        }

        private void NombreLargo_Click(object sender, EventArgs e)
        {
            NombreLargo f5 = new NombreLargo();
            f5.Show();
        }

        private void PersonasIncompletas_Click(object sender, EventArgs e)
        {
            Incompletos f6 = new Incompletos(listaOriginal);
            f6.Show();
        }
        //para cerrar el programa
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}