using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_003
{
    class CPersona : CFacultad
    {
        public string nombre;
        public string direccion;
        public string sexo;
        public int telefono;
        public CFecha fechaNacimiento = new CFecha();
        private bool aux = true;
        private int dia;
        private int mes;
        private int anho;
        public virtual void IngresarAlumno()
        {
            Console.Write("Nombre:");
            nombre = Console.ReadLine();
            Console.Write("Direccion:");
            direccion = Console.ReadLine();
            Console.Write("Sexo:");
            sexo = Console.ReadLine();
            Console.Write("Telefono:");
            telefono = int.Parse(Console.ReadLine());
            while (aux)
            {
                try
                {
                    Console.WriteLine("\nFecha de Nacimiento(DD-MM-AAAA):");
                    Console.Write("Dia:");
                    dia = int.Parse(Console.ReadLine());
                    Console.Write("Mes:");
                    mes = int.Parse(Console.ReadLine());
                    Console.Write("Año:");
                    anho = int.Parse(Console.ReadLine());
                    aux = fechaNacimiento.Verificar(dia, mes, anho);
                }
                catch (Exception)
                {
                    Console.WriteLine("\nEL DATO DEBE SER UN NUMERO ENTERO..."); Console.ReadKey();
                }
            }
        }
        public virtual void IngresoEmpleado()
        {
            Console.Write("Nombre:");
            nombre = Console.ReadLine();
            Console.Write("Direccion:");
            direccion = Console.ReadLine();
            Console.Write("Sexo:");
            sexo = Console.ReadLine();
            Console.Write("Telefono:");
            telefono = int.Parse(Console.ReadLine());
            while (aux)
            {
                try
                {
                    Console.WriteLine("\nFecha de Nacimiento(DD-MM-AAAA):");
                    Console.Write("Dia:");
                    dia = int.Parse(Console.ReadLine());
                    Console.Write("Mes:");
                    mes = int.Parse(Console.ReadLine());
                    Console.Write("Año:");
                    anho = int.Parse(Console.ReadLine());
                    aux = fechaNacimiento.Verificar(dia, mes, anho);
                }
                catch (Exception)
                {
                    Console.WriteLine("\nEL DATO DEBE SER UN NUMERO ENTERO..."); Console.ReadKey();
                }
            }
        }
        public virtual void MostrarAlumno()
        {
            Console.Write("\nNombre:{0}" +
                "\nDireccion:{1}" +
                "\nSexo:{2}" +
                "\nTelefono:{3}" +
                "\nFecha de Nacimiento:{4}/{5}/{6}", nombre, direccion, sexo, telefono,dia,mes,anho);
        }
        public virtual void MostrarEmpleado()
        {
            Console.Write("\nNombre:{0}" +
                "\nDireccion:{1}" +
                "\nSexo:{2}" +
                "\nTelefono:{3}" +
                "\nFecha de Nacimiento:{4}/{5}/{6}", nombre, direccion, sexo, telefono, dia, mes, anho);
        }
    }
}
