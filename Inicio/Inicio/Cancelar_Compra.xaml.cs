using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Inicio
{
    /// <summary>
    /// Lógica de interacción para Cancelar_Compra.xaml
    /// </summary>
    public partial class Cancelar_Compra : Window
    {
        public Cancelar_Compra()
        {
            InitializeComponent();
        }

        public Cancelar_Compra(Button send, Sala s)
        {
            enviar = send;
            sala = s;

            InitializeComponent();
        }

        Button enviar;
        Sala sala;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*cambiamos el color del boton a blanco, se elimina en el otro formulario*/
            enviar.Background = Brushes.White;
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /*cierra pestaña emergente*/
            Close();
        }
    }
}
