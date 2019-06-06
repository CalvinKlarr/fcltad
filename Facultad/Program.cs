using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Program
    {
        static void Main(string[] args)
        {

            bool josi = false;

            while (!josi)
            {

            Console.WriteLine("\t --- Bienvenido a UNI-APP --- ");
            Console.WriteLine("\t  ");
            Console.WriteLine(" 1- Inscribirse a asignatura. ");
            Console.WriteLine(" 2- Alumnos. ");
            Console.WriteLine(" 3- Aula. ");
            Console.WriteLine(" 4- Profesores. ");
            Console.WriteLine(" 5- Cambiar asignaturas por profesor. ");
            Console.WriteLine(" 6- Salir ");

            int caseSwitch = Convert.ToInt16(Console.ReadLine());


                switch (caseSwitch)
                {
                    case 1:

                        Console.WriteLine("\t --- UNI-APP --- ");
                        Console.WriteLine("\t  ");
                        Console.WriteLine(" 1- Ingresar asignatura deseada ");
                        Console.WriteLine(" 2- Ingresar Num de legajo ");


                        break;

                    case 2:

                        Console.WriteLine("\t --- UNI-APP --- ");
                        Console.WriteLine("\t  ");
                        Console.WriteLine(" 1- Ver alumnos por curso ");
                        Console.WriteLine(" 2- Ver alumnos por materia ");
                        Console.WriteLine(" 3- Ver calificaciones de alumnos ");
                        Console.WriteLine(" 4- Subir calificaciones ");
                        Console.WriteLine(" 5- Dar de baja ");
                        Console.WriteLine(" 6- Modificar ");
                        Console.WriteLine(" 7- Volver al Menu principal ");

                        int caseSwitchAlumno = Convert.ToInt16(Console.ReadLine());

                                    switch (caseSwitchAlumno)
                                    {
                                    /*case 1: ; break;
                                    case 2: ; break;
                                    case 3: ; break;
                                    case 4: ; break;
                                    case 5: ; break;
                                    case 6: ; break; */
                                    case 7:  continue; break;
                                    }
                        break;

                    case 3:
                        Console.WriteLine("\t --- UNI-APP --- ");
                        Console.WriteLine("\t  ");
                        Console.WriteLine(" 1- Ver aulas ");
                        Console.WriteLine(" 2- Cambiar aulas ");
                        Console.WriteLine(" 3- Dar de alta ");
                        Console.WriteLine(" 4- Dar de baja ");
                        Console.WriteLine(" 5- Modificar ");
                        Console.WriteLine(" 6- Volver al Menu principal ");

                     


                        break;
                    case 4:

                        Console.WriteLine("\t --- UNI-APP --- ");
                        Console.WriteLine("\t  ");
                        Console.WriteLine(" 1- Ver profesores ");
                        Console.WriteLine(" 2- Dar de alta ");
                        Console.WriteLine(" 3- Dar de baja ");
                        Console.WriteLine(" 4- Modificar ");
                        Console.WriteLine(" 5- Volver al Menu principal ");


                        break;

                    case 5:

                     


                        break;

                    case 6:
                        josi = true;
                        break;


                }

            }
        }
    }
}
