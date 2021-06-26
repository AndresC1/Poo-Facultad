using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_003
{
    class CBecadoExt : CAlumno
    {
        protected float monto;
        public override void IngresarAlumno()
        {
            base.IngresarAlumno();
            Console.Write("Monto:");
            monto = float.Parse(Console.ReadLine());
        }
        public override void MostrarAlumno()
        {
            base.MostrarAlumno();
            Console.WriteLine("Monto:{0}", monto);
        }
        public bool BuscarBecadoExt(string Enombre, string Ecarnet, float Emonto)
        {
            if (Enombre == nombre && Ecarnet == carnet && Emonto == monto)
            {
                return true;
            }
            else return false;
        }/*
        public bool BuscarBecadoExt()
        {
            CBecadoExt externo = new CBecadoExt();
            string Enombre, Ecarnet;
            float Emonto;
            Console.Write("Ingrese el Nombre:");
            Enombre = Console.ReadLine();
            Console.Write("Ingrese el Carnet:");
            Ecarnet = Console.ReadLine();
            Console.Write("Ingrese el Monto de la Beca:");
            Emonto = float.Parse(Console.ReadLine());
            if (Enombre == nombre && Ecarnet == carnet && Emonto == monto)
            {
                return true;
            }
            else return false;
        }*/
    }
}
