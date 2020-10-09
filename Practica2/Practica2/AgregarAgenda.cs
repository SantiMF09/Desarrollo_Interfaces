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
    public partial class AgregarAgenda : Form
    {
        public AgregarAgenda()
        {
            InitializeComponent();
        }

        private void agendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.miagendaDataSet1);

        }

        private void AgregarAgenda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet1.tarea' Puede moverla o quitarla según sea necesario.
            this.tareaTableAdapter.Fill(this.miagendaDataSet1.tarea);
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet1.agenda' Puede moverla o quitarla según sea necesario.
            this.agendaTableAdapter.Fill(this.miagendaDataSet1.agenda);

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
