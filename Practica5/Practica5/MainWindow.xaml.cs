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

namespace Practica5
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
        List<Asiento> asiento;

        /*creams las salas para pasarlas a los formularios*/
        Sala sala1;
        Sala sala2;
        Sala sala3;
        Sala sala4;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*Para añadir eventos*/
            sala1 = new Sala("El Rey Leon", "17:50", "19/11/2020", new List<Asiento>(), 5, 10, "1");
            sala2 = new Sala("La Celestina", "19:45", "25/11/2020", new List<Asiento>(), 10, 10, "2");
            sala3 = new Sala("Romeo y Julieta", "20:00", "5/12/2020", new List<Asiento>(), 9, 20, "3");
            sala4 = new Sala("Don Juan Tenorio", "12:30", "18/1/2021", new List<Asiento>(), 5, 5, "4");
        }

        private void Espectaculo_1_Click(object sender, RoutedEventArgs e)
        {
            /*Creamos el enlace a la ventana de asientos, pasando por parametros la lista de objetos y la 
             informacion de la sala*/
            Espectaculo f1 = new Espectaculo(asiento, sala1);
            f1.Show();
        }

        private void Espectaculo_2_Click(object sender, RoutedEventArgs e)
        {
            Espectaculo f1 = new Espectaculo(asiento, sala2);
            f1.Show();
        }

        private void Espectaculo_3_Click(object sender, RoutedEventArgs e)
        {
            Espectaculo f1 = new Espectaculo(asiento, sala3);
            f1.Show();
        }
        private void Espectaculo_4_Click(object sender, RoutedEventArgs e)
        {
            Espectaculo f1 = new Espectaculo(asiento, sala4);
            f1.Show();
        }
    }
}
