using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Practica1
{
    
    public partial class Incompletos : Form
    {
        public Incompletos()
        {
            InitializeComponent();
        }
        //creamos tambien la referencia en esta clase
        List<Persona> listaOriginal;
        //Creamos una lista para comprarla con la original y no modificarla
        public Incompletos(List<Persona> LP)
        {
            listaOriginal = LP;
            InitializeComponent();
        }

        private void listIncompletas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Incompletos_Load(object sender, EventArgs e)
        {
            //contador para que sepa si hay algun usuario sin copletar información
            int cont = 0;
            //un foreach como el del DNi para recorrer toda la lista 
            foreach (Persona per in listaOriginal)
            {
                //comprobamos si hay algun campo vacio en alguno de los atributos
                if (per.Apellidos1 == "" || per.DNI1 == "" || per.Peso1 == 0 || per.Nombre1 == "" || per.Altura1 == 0)
                {
                    //si se cumple debe mostrar el toString del objeto
                    listIncompletas.Items.Add(per.ToString());
                    //al encotrar a un usuario ya sabemos que algun no esta completo, esto nos hará no entrar en el siguinete if
                    cont++;
                }
            }
            if (cont == 0)
            {
                //en caso que el contador no de haya movida significara que todos los usuarios estan completos
                MessageBox.Show("Todos los usuarios tienen todos sus datos completos");
            }
        }
    }
}