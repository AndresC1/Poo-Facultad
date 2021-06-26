using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_003
{
    class CEmpleado : CPersona
    {
        protected int numeroINSS;
        protected string titulo;
        protected string cargo;
        protected float salario;
        protected int antiguedad;
        public override void IngresoEmpleado()
        {
            base.IngresoEmpleado();
            Console.Write("Numero de INSS:");
            numeroINSS = int.Parse(Console.ReadLine());
            Console.Write("Titulo:");
            titulo = Console.ReadLine();
            Console.Write("Cargo:");
            cargo = Console.ReadLine();
            Console.Write("Salario:");
            salario = float.Parse(Console.ReadLine());
            Console.Write("Antiguedad:");
            antiguedad = int.Parse(Console.ReadLine());
        }
        public override void MostrarEmpleado()
        {
            base.MostrarEmpleado();
            Console.Write("\nNumero de INSS:{0}" +
                "\nTitulo:{1}" +
                "\nCargo:{2}" +
                "\nSalario: C${3}" +
                "\nAntiguedad:{4}", numeroINSS, titulo, cargo, salario, antiguedad);
        }
    }
}
