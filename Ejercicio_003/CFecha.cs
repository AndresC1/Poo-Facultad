using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_003
{
    class CFecha
    {
        public bool Verificar(int dia, int mes, int anho)
        {
            if ((dia > 0) && (dia < 31) && (mes > 0) && (mes <= 12) && (anho < 2021))
            {
                return false;
            }
            else
            {
                Console.WriteLine("Fecha Invalida...");
                Console.ReadKey();
                return true;
            }
        }
    }
}
