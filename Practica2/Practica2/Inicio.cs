using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonViewAgenda_Click(object sender, EventArgs e)
        {
            VerAgendas f2 = new VerAgendas();
            f2.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCTarea_Click(object sender, EventArgs e)
        {
            MTareas f3 = new MTareas();
            f3.Show();
        }

        private void buttonNewAgenda_Click(object sender, EventArgs e)
        {
            AgregarAgenda f4 = new AgregarAgenda();
            f4.Show();
        }
    }
}
