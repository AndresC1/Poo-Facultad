using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_003
{
    class CAdministrativo : CEmpleado
    {
        protected string dependencia;
        public override void IngresoEmpleado()
        {
            base.IngresoEmpleado();
            Console.Write("Dependencia:");
            dependencia = Console.ReadLine();
        }
        public override void MostrarEmpleado()
        {
            base.MostrarEmpleado();
            Console.WriteLine("\nDependencia:{0}", dependencia);
        }
        public bool BuscarAdministrativo(string Enombre, int EnumeroINSS, string Edependencia)
        {
            if (Enombre == nombre && EnumeroINSS == numeroINSS && Edependencia == dependencia)
            {
                return true;
            }
            else return false;
        }/*
        public bool BuscarAdministrativo()
        {
            CAdministrativo ad = new CAdministrativo();
            string Enombre, Edependencia;
            int EnumeroINSS;
            Console.Write("Ingrese el Nombre:");
            Enombre = Console.ReadLine();
            Console.Write("Ingrese el Numero de INSS:");
            EnumeroINSS = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la Dependencia:");
            Edependencia = Console.ReadLine();
            if (Enombre == nombre && EnumeroINSS == numeroINSS && Edependencia == dependencia)
            {
                return true;
            }
            else return false;
        }*/
    }
}
