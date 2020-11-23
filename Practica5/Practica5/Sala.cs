using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class Sala
    {
        /*Atributos del evento*/
        private String nombre;
        private String hora;
        private String fecha;
        private int fila;
        private int columna;
        private String nSala;

        /*Lista de los asientos de la sala*/
        List<Asiento> asiento = new List<Asiento>();

        /*constructor vacio*/
        public Sala()
        {
        }

        /*Constructor de los eventos*/
        public Sala(string nombre, string hora, string fecha, List<Asiento> asiento, int fila, int columna, string nSala)
        {
            this.nombre = nombre;
            this.hora = hora;
            this.fecha = fecha;
            this.asiento = asiento;
            this.fila = fila;
            this.columna = columna;
            this.nSala = nSala;
        }

        /*Getters y Setters del los atributos del evento*/
        public string Nombre { get => nombre; set => nombre = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public List<Asiento> Asiento { get => asiento; set => asiento = value; }
        public int Fila { get => fila; set => fila = value; }
        public int Columna { get => columna; set => columna = value; }
        public String NSala { get => nSala; set => nSala = value; }

        /*Mostrar informacion del evento*/
        public override string ToString()
        {
            return "--------INFORMACION DE LA OBRA--------\n" +
                "Nombre: " + nombre + "\t" + "Fecha: " + Fecha + "\t" + "Hora: " + Hora;
        }
    }
}
