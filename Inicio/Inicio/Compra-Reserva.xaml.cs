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
    /// Lógica de interacción para Compra_Reserva.xaml
    /// </summary>
    public partial class Compra_Reserva : Window
    {
        public Compra_Reserva()
        {
            InitializeComponent();
        }
        Button enviar;
        Sala sala;
        public Compra_Reserva(Button send, Sala s)
        {
            enviar = send;
            sala = s;

            InitializeComponent();
        }

        private void Comprar_Click(object sender, RoutedEventArgs e)
        {
            /*convertimos la primera posicion del nombre del boton a int para guardarlo en la fila*/
            int fila=Convert.ToInt32(enviar.Content.ToString().Substring(0, 1));
            /*convertimos la tercera posicion del nombre del boton a int para guardarlo en la columna*/
            int columna =Convert.ToInt32(enviar.Content.ToString().Substring(2, 1));
            /*añadimos ese asiento a la lista en forma de ocuado*/
            sala.Asiento.Add(new Asientos(columna, fila, "ocupado"));
            /*lo pintamos de rojo*/
            enviar.Background = Brushes.Red;
            /*y cerramos la ventana emergente*/
            this.Close();
        }

        private void Reservar_Click(object sender, RoutedEventArgs e)
        {
            /*igual que el boton ocupado, pero ahora para reservar*/
            int fila = Convert.ToInt32(enviar.Content.ToString().Substring(0, 1));
            int columna = Convert.ToInt32(enviar.Content.ToString().Substring(2, 1));

            sala.Asiento.Add(new Asientos(columna, fila, "reservado"));
            enviar.Background = Brushes.Orange;
            this.Close();
        }
    }
}
