using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_003
{
    class CBecadoInt : CAlumno
    {
        protected string residencia;
        protected int numeroCuarto;
        public override void IngresarAlumno()
        {
            base.IngresarAlumno();
            Console.Write("Residencia:");
            residencia = Console.ReadLine();
            Console.Write("Numero de Cuarto:");
            numeroCuarto = int.Parse(Console.ReadLine());
        }
        public override void MostrarAlumno()
        {
            base.MostrarAlumno();
            Console.WriteLine("Residencia:{0}" +
                "\nNum Cuarto:{1}", residencia, numeroCuarto);
        }
        public bool BuscarBecadoInt(string Enombre, string Ecarnet, int EnumCuarto)
        {
            if (Enombre == nombre && Ecarnet == carnet && EnumCuarto == numeroCuarto)
            {
                return true;
            }
            else return false;
        }/*
        public bool BuscarBecadoInt()
        {
            string Enombre, Ecarnet;
            int EnumCuarto;
            CBecadoInt interno = new CBecadoInt();
            Console.Write("Ingrese el Nombre:");
            Enombre = Console.ReadLine();
            Console.Write("Ingrese el Carnet:");
            Ecarnet = Console.ReadLine();
            Console.Write("Ingrese el Numero de Cuarto:");
            EnumCuarto = int.Parse(Console.ReadLine());
            if (Enombre == nombre && Ecarnet == carnet && EnumCuarto == numeroCuarto)
            {
                return true;
            }
            else return false;
        }*/
    }
}
