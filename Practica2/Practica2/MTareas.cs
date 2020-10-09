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
    public partial class MTareas : Form
    {
        public MTareas()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonModfTarea_Click(object sender, EventArgs e)
        {
            ModificarTarea t1 = new ModificarTarea();
            t1.Show();
        }

        private void buttonNewTarea_Click(object sender, EventArgs e)
        {
            CrearTarea t2 = new CrearTarea();
            t2.Show();
        }

        private void buttonDeleteTarea_Click(object sender, EventArgs e)
        {
            BorrarTarea t3 = new BorrarTarea();
            t3.Show();
        }
    }
}
