using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_003
{
    class CFacultad
    {
        private List<CPersona> personal = new List<CPersona>();
        public void AgregarBecaInt()
        {
            CBecadoInt bi = new CBecadoInt();
            bi.IngresarAlumno();
            personal.Add(bi);
        }
        public void EliminarDato(int tipo)
        {
            int aux = 0;
            
            switch (tipo)
            {
                case 1:
                    try
                    {
                        string Enombre, Ecarnet, Ecarrera;
                        CAlumno op = new CAlumno();
                        Console.Write("Ingrese el Nombre:");
                        Enombre = Console.ReadLine();
                        Console.Write("Ingrese el Carnet:");
                        Ecarnet = Console.ReadLine();
                        Console.Write("Ingrese la Carrera:");
                        Ecarrera = Console.ReadLine();
                        for (int i = 0; i < personal.Count(); i++)
                        {
                            if (op.BuscarAlumno(Enombre, Ecarrera, Ecarnet))
                            {
                                personal.RemoveAt(i);
                                aux++;
                                Console.WriteLine("ELIMINADO CON EXITO!!!");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        break;
                    }
                    break;
                case 2:
                    try
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
                        for (int i = 0; i < personal.Count(); i++)
                        {
                            if (interno.BuscarBecadoInt(Enombre, Ecarnet, EnumCuarto))
                            {
                                personal.RemoveAt(i);
                                aux++;
                                Console.WriteLine("ELIMINADO CON EXITO!!!");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        break;
                    }
                    break;
                case 3:
                    try
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
                        for (int i = 0; i < personal.Count(); i++)
                        {
                            if (externo.BuscarBecadoExt(Enombre, Ecarnet, Emonto))
                            {
                                personal.RemoveAt(i);
                                aux++;
                                Console.WriteLine("ELIMINADO CON EXITO!!!");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        break;
                    }
                    break;
                case 4:
                    try
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
                        for (int i = 0; i < personal.Count(); i++)
                        {
                            if (p.BuscarProfesor(Enombre, EnumeroINSS, Edepartamento))
                            {
                                personal.RemoveAt(i);
                                aux++;
                                Console.WriteLine("ELIMINADO CON EXITO!!!");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        break;
                    }
                    break;
                case 5:
                    try
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
                        for (int i = 0; i < personal.Count(); i++)
                        {
                            if (ad.BuscarAdministrativo(Enombre, EnumeroINSS, Edependencia))
                            {
                                personal.RemoveAt(i);
                                aux++;
                                Console.WriteLine("ELIMINADO CON EXITO!!!");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        break;
                    }
                    break;
            }
            if (aux == 0) Console.WriteLine("NO SE ENCONTRO EL DATO A ELIMINAR...");
        }
        public void BuscarDato(int tipo)
        {
            string Enombre, Ecarnet;
            int aux = 0, EnumeroINSS;
            int mn;
            switch (tipo)
            {
                case 1:
                    string Ecarrera;
                    mn = 0;
                    CAlumno op = new CAlumno();
                    Console.Write("Ingrese el Nombre:");
                    Enombre = Console.ReadLine();
                    Console.Write("Ingrese el Carnet:");
                    Ecarnet = Console.ReadLine();
                    Console.Write("Ingrese la Carrera:");
                    Ecarrera = Console.ReadLine();
                    while (mn != personal.Count()+1)
                    {
                        Console.WriteLine("1");
                        mn++;
                        try
                        {
                            op = (CAlumno)personal[mn];
                            if (op.BuscarAlumno(Enombre, Ecarrera, Ecarnet))
                            {
                                personal[mn].MostrarAlumno(); Console.ReadKey(); Console.Clear();
                                aux++;
                            }
                        }
                        catch (Exception)
                        {
                            break;
                        }
                        Console.WriteLine("2");
                    }
                    break;
                case 2:
                    int EnumCuarto;
                    mn = 0;
                    CBecadoInt interno = new CBecadoInt();
                    Console.Write("Ingrese el Nombre:");
                    Enombre = Console.ReadLine();
                    Console.Write("Ingrese el Carnet:");
                    Ecarnet = Console.ReadLine();
                    Console.Write("Ingrese el Numero de Cuarto:");
                    EnumCuarto = int.Parse(Console.ReadLine());
                    while (mn != personal.Count() + 1)
                    {
                        mn++;
                        try
                        {
                            interno = (CBecadoInt)personal[mn];
                            if (interno.BuscarBecadoInt(Enombre, Ecarnet, EnumCuarto))
                            {
                                personal[mn].MostrarAlumno(); Console.ReadKey(); Console.Clear();
                                aux++;
                            }
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    }
                    break;
                case 3:
                    mn = 0;
                    CBecadoExt externo = new CBecadoExt();
                    float Emonto;
                    Console.Write("Ingrese el Nombre:");
                    Enombre = Console.ReadLine();
                    Console.Write("Ingrese el Carnet:");
                    Ecarnet = Console.ReadLine();
                    Console.Write("Ingrese el Monto de la Beca:");
                    Emonto = float.Parse(Console.ReadLine());
                    while (mn != personal.Count() + 1)
                    {
                        mn++;
                        try
                        {
                            externo = (CBecadoExt)personal[mn];
                            if (externo.BuscarBecadoExt(Enombre, Ecarnet, Emonto))
                            {
                                personal[mn].MostrarAlumno(); Console.ReadKey(); Console.Clear();
                                aux++;
                            }
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    }
                    break;
                case 4:
                    mn = 0;
                    CProfesor p = new CProfesor();
                    string Edepartamento;
                    Console.Write("Ingrese el Nombre:");
                    Enombre = Console.ReadLine();
                    Console.Write("Ingrese el Numero de INSS:");
                    EnumeroINSS = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el Departamento:");
                    Edepartamento = Console.ReadLine();
                    while (mn != personal.Count() + 1)
                    {
                        Console.WriteLine("1");
                        mn++;
                        try
                        {
                            p = (CProfesor)personal[mn];
                            if (p.BuscarProfesor(Enombre, EnumeroINSS, Edepartamento))
                            {
                                personal[mn].MostrarEmpleado(); Console.ReadKey(); Console.Clear();
                                aux++;
                            }
                        }
                        catch (Exception)
                        {
                            break;
                        }
                        Console.WriteLine("1");
                    }
                    break;
                case 5:
                    mn = 0;
                    CAdministrativo ad = new CAdministrativo();
                    string Edependencia;
                    Console.Write("Ingrese el Nombre:");
                    Enombre = Console.ReadLine();
                    Console.Write("Ingrese el Numero de INSS:");
                    EnumeroINSS = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la Dependencia:");
                    Edependencia = Console.ReadLine();
                    while (mn!=personal.Count() + 1)
                    {
                        mn++;
                        try
                        {
                            ad = (CAdministrativo)personal[mn];
                            if (ad.BuscarAdministrativo(Enombre,EnumeroINSS,Edependencia))
                            {
                                personal[mn].MostrarEmpleado(); Console.ReadKey(); Console.Clear();
                                aux++;
                            }
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    }
                    break;
            }
            if (aux == 0) Console.WriteLine("NO SE ENCONTRO EL DATO A BUSCAR...");
        }
        public void EliminarTodo()
        {
            for (int i=0; i<personal.Count(); i++)
            {
                personal.RemoveAt(0);
            }
        }
        public void AgregarBecaExt()
        {
            CBecadoExt be = new CBecadoExt();
            be.IngresarAlumno();
            personal.Add(be);
        }
        public void AgregarAlumno()
        {
            CAlumno Al = new CAlumno();
            Al.IngresarAlumno();
            personal.Add(Al);
        }
        public void AgregarAdministrativo()
        {
            CAdministrativo Ad = new CAdministrativo();
            Ad.IngresoEmpleado();
            personal.Add(Ad);
        }
        public void AgregarProfesor()
        {
            CProfesor pro = new CProfesor();
            pro.IngresoEmpleado();
            personal.Add(pro);
        }
    }
}
