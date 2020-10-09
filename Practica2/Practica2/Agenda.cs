using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Agenda
    {
        //Atributos
        private int id;
        private string nombre;
        private int año;
        //Contrusctor
        public Agenda(int id, string nombre, int año)
        {
            this.id = id;
            this.nombre = nombre;
            this.año = año;
        }
        //Getters y Setters
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Año { get => año; set => año = value; }
    }
}
