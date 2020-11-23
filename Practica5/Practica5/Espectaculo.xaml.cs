﻿using System;
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

namespace Practica5
{
    /// <summary>
    /// Lógica de interacción para Espectaculo.xaml
    /// </summary>
    public partial class Espectaculo : Window
    {
        public Espectaculo()
        {
            InitializeComponent();
        }
        /*pasamos referencia de la lista de asientos y los objetos de sala (los eventos)*/
        List<Asiento> asiento;
        Sala salas =  new Sala();

        /*Creamos una lista para comprarla con la original y no modificarla y una referncia al objeto */
        public Espectaculo(List<Asiento> asientos, Sala s)
        {
            asiento = asientos;

            salas = s;

            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*Para cambiar los text views del formulario, dependiendo el evento selecionado*/
            NEvento.Text = salas.Nombre;
            DiaEvento.Text = salas.Fecha;
            HoraEvento.Text = salas.Hora;
            NSala.Text = salas.NSala;

            //Crear filas y columnas para alojar botones
            for (int f = 0; f < salas.Fila; f++)
            {
                GridAsientos.RowDefinitions.Add(new RowDefinition());
            }
            for (int c = 0; c < salas.Columna; c++)
            {
                GridAsientos.ColumnDefinitions.Add(new ColumnDefinition());
            }

            //Un for anidado para crear los botones en las filas y columnas correspondientes
            for (int fila = 0; fila < salas.Fila; fila++)
                for (int columna = 0; columna < salas.Columna; columna++)
                {
                    Button b = new Button();
                    b.Name = "boton" + fila + columna;
                    b.Click += Button_Click;
                    GridAsientos.Children.Add(b);
                    Grid.SetRow(b, fila);
                    Grid.SetColumn(b, columna);
                    b.Content = fila + "." + columna;
                }

                    /*un for each para recorrer todos los botones del primer Grid*/
                    UIElementCollection a = GridAsientos.Children;
            foreach (UIElement x in a)
            {
                /*un foreach para recorrer los asientos del evento*/
                foreach (Asiento y in salas.Asiento)
                {
                    /*guardamos las filas y columnas en un string, para concatenarlo y comprarlo con el 
                     nobre del boton*/
                    string contenido = y.Fila + "." + y.Columna;
                    //
                    /*Aquí se compara*/
                    if (contenido.Equals(((Button)x).Content.ToString()))
                    {
                        /*si esta ocupado que lo rellene de rojo*/
                        if (y.Estado.Equals("ocupado"))
                        {
                            ((Button)x).Background = Brushes.Red;
                        }
                        /*si no, que lo rellene de naranja, ya que si no esta ocupado, esta reservado
                         porque los libres no existen en el programa*/
                        else
                        {
                            ((Button)x).Background = Brushes.Orange;
                        }
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*casteamos el sender a un boton*/
            Button btn = (Button)sender;
            /*si el boton es de color rojo o naranja querra decir que esta comprdo o reservado*/
            if (btn.Background == Brushes.Red || btn.Background == Brushes.Orange)
            {
                /*en ese caso muestrame el formulario para cancelar la reserva o compra*/
                Cancelar_Compra f3 = new Cancelar_Compra(btn, salas);
                f3.Show();
                /*un foreach que recorra los asinetos de sala, es decir los reservados o ocupados*/
                foreach (Asiento y in salas.Asiento)
                {
                    /*como en el apartado anterior concatenamos las filas y columnas*/
                    string contenido = y.Fila + "." + y.Columna;
                    if (contenido.Equals((btn.Content.ToString())))
                    {
                        /*eliminamos el asiento del evento respecto a su fila y columna*/
                        salas.Asiento.Remove(y);
                        break;
                    }
                }
            }
            else
            {
                /*si no es ta comprado o reservado, abre el formulario del reservar o comprar*/
                Compra_Reserva f2 = new Compra_Reserva(btn, salas);
                f2.Show();
            }
        }
    }
}