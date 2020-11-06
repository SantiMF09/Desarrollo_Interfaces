using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    public class Sala
    {
        /*Atributos del evento*/
        private String nombre;
        private String hora;
        private String fecha;

        /*Lista de los asientos de la sala*/
        List<Asientos> asiento = new List<Asientos>();

        /*constructor vacio*/
        public Sala()
        {
        }

        /*Constructor de los eventos*/
        public Sala(string nombre, string hora, string fecha, List<Asientos> asiento)
        {
            this.nombre = nombre;
            this.hora = hora;
            this.fecha = fecha;
            this.asiento = asiento;
        }

        /*Getters y Setters del los atributos del evento*/
        public string Nombre { get => nombre; set => nombre = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public List<Asientos> Asiento { get => asiento; set => asiento = value; }

        /*Mostrar informacion del evento*/
        public override string ToString()
        {
            return "--------INFORMACION DE LA OBRA--------\n" +
                "Nombre: " + nombre + "\t" + "Fecha: " + Fecha + "\t" + "Hora: " + Hora ;
        }
    }
}
