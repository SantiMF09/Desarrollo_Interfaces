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
    public partial class VerAgendas : Form
    {
        public VerAgendas()
        {
            InitializeComponent();
        }

        private void agendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.miagendaDataSet1);

        }

        private void VerAgendas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet1.tarea' Puede moverla o quitarla según sea necesario.
            this.tareaTableAdapter.Fill(this.miagendaDataSet1.tarea);
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet1.agenda' Puede moverla o quitarla según sea necesario.
            this.agendaTableAdapter.Fill(this.miagendaDataSet1.agenda);

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.agendaTableAdapter.FAnnio(this.miagendaDataSet1.agenda,Convert.ToInt32(textBox1.Text));
            this.tareaTableAdapter.MTarea(this.miagendaDataSet1.tarea,Convert.ToInt32(textBox1.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBDia_Click(object sender, EventArgs e)
        {
            FiltrarDia FD = new FiltrarDia();
            FD.Show();
        }

        private void buttonBMes_Click(object sender, EventArgs e)
        {
            FiltrarMes FM = new FiltrarMes();
            FM.Show();
        }

        private void tareaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
