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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Inicio
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<Asientos> asiento;

        /*creams las salas para pasarlas a los formularios*/
        Sala sala1;
        Sala sala2;
        Sala sala3;
        Sala sala4;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*Para añadir eventos*/
            sala1 = new Sala("El Rey Leon", "17:50", "19/11/2020", new List<Asientos>());
            sala2 = new Sala( "La Celestina", "17:50", "19/11/2020", new List<Asientos>());
            sala3 = new Sala("Romeo y Julieta", "17:50", "19/11/2020", new List<Asientos>());
            sala4 = new Sala( "Don Juan Tenorio", "17:50", "19/11/2020", new List<Asientos>());
        }

        private void Espectaculo_1_Click(object sender, RoutedEventArgs e)
        {
            /*Creamos el enlace a la ventana de asientos, pasando por parametros la lista de objetos y la 
             informacion de la sala*/
            Espectaculo1 f1 = new Espectaculo1(asiento, sala1);
            f1.Show();
        }

        private void Espectaculo_2_Click(object sender, RoutedEventArgs e)
        {
            Espectaculo1 f1 = new Espectaculo1(asiento, sala2);
            f1.Show();
        }

        private void Espectaculo_3_Click(object sender, RoutedEventArgs e)
        {
            Espectaculo1 f1 = new Espectaculo1(asiento, sala3);
            f1.Show();
        }
        private void Espectaculo_4_Click(object sender, RoutedEventArgs e)
        {
            Espectaculo1 f1 = new Espectaculo1(asiento, sala4);
            f1.Show();
        }
    }
}
