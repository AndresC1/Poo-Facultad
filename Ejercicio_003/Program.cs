using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_003
{
    class Program
    {
        static void Main(string[] args)
        {
            CFacultad p = new CFacultad();
            int i = 0;
            while (i==0)
            {
                switch (MenuPrincipal())
                {
                    case 1:
                        Console.Clear();
                        Acciones(1, MenuSecundario(1), p);
                        break;
                    case 2:
                        Console.Clear();
                        Acciones(2, MenuSecundario(2), p);
                        break;
                    case 3:
                        Console.Clear();
                        Acciones(4, MenuSecundario(1), p);
                        break;
                    case 4:
                        Console.Clear();
                        Acciones(5, MenuSecundario(2), p);
                        break;
                    case 5:
                        Console.Clear();
                        Acciones(3, MenuSecundario(3), p);
                        break;
                    case 6:
                        Console.Clear();
                        p.EliminarTodo();
                        Console.WriteLine("LOS DATOS HAN SIDO ELIMINADOS");
                        Console.ReadKey(); Console.Clear();
                        break;
                    case 7:
                        i++;
                        break;
                    default:
                        break;
                }
            }
            Console.ReadKey();
        }
        public static int MenuPrincipal()
        {
            int op;
            while (true)
            {
                try
                {
                    Console.Write("***** MENU DE OPCIONES *****" +
                    "\n1. Ingresar Alumno." +
                    "\n2. Ingresar Empleado." +
                    "\n3. Eliminar Alumno." +
                    "\n4. Eliminar Empleado." +
                    "\n5. Buscar Persona." +
                    "\n6. Eliminar Todo." +
                    "\n7. Salir." +
                    "\n\tQUE ACCION DESEA REALIZAR:");
                    op = int.Parse(Console.ReadLine());
                    return op;
                }
                catch (Exception)
                {
                    Console.WriteLine("EL VALOR DEBE SER UN NUMERO ENTERO..."); Console.ReadKey(); Console.Clear();
                    throw;
                }
            }
        }
        public static int MenuSecundario(int tipo)
        {
            int op;
            while (true)
            {
                if (tipo == 1)
                {
                    try
                    {
                        Console.Write("1. Alumno." +
                            "\n2. Becado Interno." +
                            "\n3. Becado Externo." +
                            "\n4. Regresar." +
                            "\nQUE ACCION DESEA REALIZAR:");
                        op = int.Parse(Console.ReadLine());
                        return op;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("EL VALOR DEBE DE SER UN NUMERO ENTERO"); Console.ReadKey(); Console.Clear();
                        throw;
                    }
                }
                if (tipo == 2)
                {
                    try
                    {
                        Console.Write("1. Profesor." +
                            "\n2. Administrativo." +
                            "\n3. Regresar." +
                            "\nQUE ACCION DESEA REALIZAR:");
                        op = int.Parse(Console.ReadLine());
                        return op;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("EL VALOR DEBE DE SER UN NUMERO ENTERO"); Console.ReadKey(); Console.Clear();
                        throw;
                    }
                }
                if (tipo == 3)
                {
                    try
                    {
                        Console.Write("1. Buscar Alumno." +
                            "\n2. Buscar Becado Externo." +
                            "\n3. Buscar Becado Interno" +
                            "\n4. Buscar Profesor" +
                            "\n5. Buscar Administrativo" +
                            "\n6. Regresar." +
                            "\nQUE ACCION DESEA REALIZAR:");
                        op = int.Parse(Console.ReadLine());
                        return op;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("EL VALOR DEBE DE SER UN NUMERO ENTERO"); Console.ReadKey(); Console.Clear();
                        throw;
                    }
                }
            }
        }
        public static void Acciones(int tipo, int op, CFacultad l)
        {
            if (tipo == 1)
            {
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        l.AgregarAlumno();
                        Console.WriteLine("REGISTRADO CON EXITO!!!");
                        Console.ReadKey(); Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        l.AgregarBecaInt();
                        Console.WriteLine("REGISTRADO CON EXITO!!!");
                        Console.ReadKey(); Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        l.AgregarBecaExt();
                        Console.WriteLine("REGISTRADO CON EXITO!!!");
                        Console.ReadKey(); Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
            if (tipo == 2)
            {
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        l.AgregarProfesor();
                        Console.WriteLine("REGISTRADO CON EXITO!!!");
                        Console.ReadKey(); Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        l.AgregarAdministrativo();
                        Console.WriteLine("REGISTRADO CON EXITO!!!");
                        Console.ReadKey(); Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
            if (tipo == 3)
            {
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        l.BuscarDato(1);
                        Console.ReadKey(); Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        l.BuscarDato(3);
                        Console.ReadKey(); Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        l.BuscarDato(2);
                        Console.ReadKey(); Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        l.BuscarDato(4);
                        Console.ReadKey(); Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        l.BuscarDato(5);
                        Console.ReadKey(); Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
            if (tipo == 4)
            {
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        l.EliminarDato(1);
                        Console.ReadKey(); Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        l.EliminarDato(2);
                        Console.ReadKey(); Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        l.EliminarDato(3);
                        Console.ReadKey(); Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
            if (tipo == 5)
            {
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        l.EliminarDato(4);
                        Console.ReadKey(); Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        l.EliminarDato(5);
                        Console.ReadKey(); Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
