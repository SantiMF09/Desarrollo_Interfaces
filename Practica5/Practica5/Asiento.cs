using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class Asiento
    {
        private int columna;    /*vertical*/
        private int fila;       /*horizontal*/
        private String estado;  /*Ocupado, Libre, Reservado*/

        /*constructor*/
        public Asiento(int columna, int fila, string estado)
        {
            this.columna = columna;
            this.fila = fila;
            this.estado = estado;
        }

        /*Setter y Getters*/
        public int Columna { get => columna; set => columna = value; }
        public int Fila { get => fila; set => fila = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
