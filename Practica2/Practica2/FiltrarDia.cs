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
    public partial class FiltrarDia : Form
    {
        public FiltrarDia()
        {
            InitializeComponent();
        }

        private void tareaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tareaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.miagendaDataSet1);

        }

        private void FiltrarDia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet1.tarea' Puede moverla o quitarla según sea necesario.
            this.tareaTableAdapter.Fill(this.miagendaDataSet1.tarea);

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            this.tareaTableAdapter.FDia(this.miagendaDataSet1.tarea, Convert.ToInt32(textMes.Text), Convert.ToInt32(textDia.Text), Convert.ToInt32(textAnnio.Text));
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
