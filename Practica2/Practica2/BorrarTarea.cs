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
    public partial class BorrarTarea : Form
    {
        public BorrarTarea()
        {
            InitializeComponent();
        }

        private void tareaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tareaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.miagendaDataSet1);

        }

        private void BorrarTarea_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet1.tarea' Puede moverla o quitarla según sea necesario.
            this.tareaTableAdapter.Fill(this.miagendaDataSet1.tarea);

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
