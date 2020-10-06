using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public class Persona
    {
        //Atributos
        private String DNI;
        private String Nombre;
        private String Apellidos;
        private double Altura;
        private double Peso;
        private DateTime Fecha_Nacimento;

        //Constructor vacio
        public Persona()
        {

        }
        //Constructor con los atributos de la clase
        public Persona(string dNI, string nombre, string apellidos, double altura, double peso, DateTime fecha_Nacimento)
        {
            DNI = dNI;
            Nombre = nombre;
            Apellidos = apellidos;
            Altura = altura;
            Peso = peso;
            Fecha_Nacimento = fecha_Nacimento;
        }
        

        //Getters Y Setters
        public string DNI1 { get => DNI; set => DNI = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public double Altura1 { get => Altura; set => Altura = value; }
        public double Peso1 { get => Peso; set => Peso = value; }
        public DateTime Fecha_Nacimento1 { get => Fecha_Nacimento; set => Fecha_Nacimento = value; }
        
        //Visor de Persona
        public override string ToString()
        {
            return "DNI: "+ DNI1 + "\t " + "Nombre: " + Nombre1 + "\t" + "Apellidos: " + Apellidos1 + "\t" + "Altura: " +
                  Altura1 + "m" + "\t\t" + "Peso: " + Peso1 + "Kg" + "\t" + "Fecha de Nacimiento: " + Fecha_Nacimento1;
        }
    }
}