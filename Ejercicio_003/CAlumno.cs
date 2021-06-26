using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_003
{
    class CAlumno : CPersona
    {
        public string carnet;
        protected string carrera;
        public override void IngresarAlumno()
        {
            base.IngresarAlumno();
            Console.Write("Carnet:");
            carnet = Console.ReadLine();
            Console.Write("Carrera:");
            carrera = Console.ReadLine();
        }
        public override void MostrarAlumno()
        {
            base.MostrarAlumno();
            Console.WriteLine("\nCarnet:{0}" +
                "\nCarrera:{1}", carnet, carrera);
        }
        public bool BuscarAlumno(string Enombre, string Ecarrera, string Ecarnet)
        {
            if (Enombre == nombre && Ecarnet == carnet && Ecarrera == carrera)
            {
                return true;
            }
            else return false;
        }/*
        public bool BuscarAlumno()
        {
            string Enombre, Ecarnet, Ecarrera;
            CAlumno op = new CAlumno();
            Console.Write("Ingrese el Nombre:");
            Enombre = Console.ReadLine();
            Console.Write("Ingrese el Carnet:");
            Ecarnet = Console.ReadLine();
            Console.Write("Ingrese la Carrera:");
            Ecarrera = Console.ReadLine();
            if (Enombre == nombre && Ecarnet == carnet && Ecarrera == carrera)
            {
                return true;
            }
            else return false;
        }*/
    }
}
