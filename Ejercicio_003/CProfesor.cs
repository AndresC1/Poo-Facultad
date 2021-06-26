using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_003
{
    class CProfesor : CEmpleado
    {
        protected string departamento;
        protected string categoria;
        public override void IngresoEmpleado()
        {
            base.IngresoEmpleado();
            Console.Write("Departamento:");
            departamento = Console.ReadLine();
            Console.Write("Categoria:");
            categoria = Console.ReadLine();
        }
        public override void MostrarEmpleado()
        {
            base.MostrarEmpleado();
            Console.WriteLine("\nDepartamento:{0}" +
                "\nCategoria:{1}",departamento, categoria);
        }
        public bool BuscarProfesor(string Enombre, int EnumeroINSS, string Edepartamento)
        {
            if (Enombre == nombre && EnumeroINSS == numeroINSS && Edepartamento == departamento)
            {
                return true;
            }
            else return false;
        }/*
        public bool BuscarProfesor()
        {
            CProfesor p = new CProfesor();
            string Enombre, Edepartamento;
            int EnumeroINSS;
            Console.Write("Ingrese el Nombre:");
            Enombre = Console.ReadLine();
            Console.Write("Ingrese el Numero de INSS:");
            EnumeroINSS = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el Departamento:");
            Edepartamento = Console.ReadLine();
            if (Enombre == nombre && EnumeroINSS == numeroINSS && Edepartamento == departamento)
            {
                return true;
            }
            else return false;
        }*/
    }
}
