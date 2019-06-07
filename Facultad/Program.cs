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



            //Espacio para rellenar los datos de alumnos, cursos, profes, etc


            // Esto controla el bucle del MENU PRINCIPAL
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

                    // 1- INSCRIBIRSE A ASIGNATURA: 
                    case 1:

                        Console.WriteLine("\t --- UNI-APP --- ");
                        Console.WriteLine("\t  ");
                        Console.WriteLine(" Escriba exit para volver al Menu principal ");

                        Console.WriteLine(" - Ingresar la asignatura deseada ");
                        string asign = Console.ReadLine();

                        if (asign == "exit")   { continue; }
                        else { 

                        Console.WriteLine(" - Ingresar Id ");
                        int id = Convert.ToInt16(Console.ReadLine());

                        ProgramControl inscrib = new ProgramControl();
                       
                        inscrib.inscribir(id, asign );
                        }

                        break;

                        //2- MENU ALUMNO

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
                                    case 1:
                                Console.WriteLine("\t --- UNI-APP --- ");
                                Console.WriteLine("\t  ");
                                Console.WriteLine(" Escriba exit para volver al Menu principal ");
                                Console.WriteLine(" Ingrese el curso del cual quiere ver los alumnos:  ");

                                string cursoDeseado = Console.ReadLine();
                                if (cursoDeseado == "exit") { continue; }
                                        else
                                        {
                                    ProgramControl verStudents = new ProgramControl();

                                    List<Alumno> alumnosporCurso = verStudents.verAlumnosPorCurso(cursoDeseado);
                                            foreach (var i in alumnosporCurso)
                                            {

                                            Console.WriteLine("\t"+i.Apellido+" "+ i.Nombre);

                                            }
                                        }
                                    ; break;


                                    case 2:

                                Console.WriteLine("\t --- UNI-APP --- ");
                                Console.WriteLine("\t  ");
                                Console.WriteLine(" Escriba exit para volver al Menu principal ");
                                Console.WriteLine(" Ingrese la materia de la cual quiere ver los alumnos:  ");

                                string materiaDeseada = Console.ReadLine();
                                if (materiaDeseada == "exit") { continue; }
                                else
                                {
                                    ProgramControl verStudentsM = new ProgramControl();

                                    List<Alumno> alumnosporMateria = verStudentsM.verAlumnosPorMateria(materiaDeseada);
                                    foreach (var i in alumnosporMateria)
                                    {

                                        Console.WriteLine("\t" + i.Apellido + " " + i.Nombre);
                                    }
                                }

                                    ; break;




                                    //3- VER CALIFICACIONES DE ALUMNOS
                                    case 3:

                                Console.WriteLine("\t --- UNI-APP --- ");
                                Console.WriteLine("\t  ");
                                Console.WriteLine(" Escriba exit para volver al Menu principal ");
                                Console.WriteLine(" Ingrese la asignatura de la cual quiere ver las calificaciones:  ");

                                string asignDeseada = Console.ReadLine();
                                if (asignDeseada == "exit") { continue; }
                                else
                                {
                                    ProgramControl vercalifications = new ProgramControl();

                                    Console.WriteLine("\t"+ vercalifications.verCalificaciones(asignDeseada));
                                }
                                    ; break;




                                    //4- SUBIR CALIFICACIONES

                                    case 4:

                                    Console.WriteLine("\t --- UNI-APP --- ");
                                    Console.WriteLine("\t  ");
                                    Console.WriteLine(" Escriba exit para volver al Menu principal ");

                                    Console.WriteLine(" Ingrese la asignatura:  ");
                                    string asigNota = Console.ReadLine();

                                if (asigNota == "exit") { continue; }

                                else
                                {
                                    Console.WriteLine(" Ingrese el num de legajo del alumno:  ");

                                    int numLegajo = Convert.ToInt16(Console.ReadLine());

                                    bool parOrec = false;

                                    Console.WriteLine(" Sí la nota es para un PARCIAL ingrese: true  ");
                                    Console.WriteLine(" Sí la nota es para un RECUPERATORIO ingrese: false  ");

                                    parOrec = Convert.ToBoolean(Console.ReadLine());
                                    Calificacion calif = new Calificacion();


                                    if (parOrec == true)
                                    {
                                        Console.WriteLine("Ingrese el numero de PARCIAL al que desee cargar una calificación: ");
                                        int numParcial = Convert.ToInt16(Console.ReadLine());
                                        Console.WriteLine("Ingrese la calificación: ");
                                        int notaParcial = Convert.ToInt16(Console.ReadLine());
                                        calif.setParciales(numParcial, notaParcial);
                                    }
                                    else if (parOrec == false)
                                    {
                                        Console.WriteLine("Ingrese el numero de RECUPERATORIO al que desee cargar una calificación: ");
                                        int numRecup = Convert.ToInt16(Console.ReadLine());
                                        Console.WriteLine("Ingrese la calificación: ");
                                        int notaRecup = Convert.ToInt16(Console.ReadLine());
                                        calif.setRecup(numRecup, notaRecup);
                                        
                                    }

                                    ProgramControl cargarCalific = new ProgramControl();

                                    cargarCalific.subirCalificaciones(numLegajo, calif, asigNota);

                                    Console.WriteLine("La calificacion fue cargada con exito! ");



                                }   

                                    ; break; 
                                    

                                     //5- DAR DE BAJA
                                     case 5:

                                    Console.WriteLine("\t --- UNI-APP --- ");
                                    Console.WriteLine("\t  ");
                                    Console.WriteLine(" Escriba 7 para volver al Menu principal ");
                                    Console.WriteLine(" Ingrese el num de legajo del alumno al que quiere dar de baja:  ");

                                    int idleg =Convert.ToInt16( Console.ReadLine());
                                    if (idleg == 7) { continue; }
                                        else
                                        {
                                            ProgramControl baja = new ProgramControl();
                                            baja.bajaAlumno(idleg);
                                            Console.WriteLine("El alumno fue dado de baja con exito! ");
                                        }

                                    ; break;



                                    case 6:


                                        ; break;
                                    case 7:  continue; break;

                                    }
                    
                          break;


                    //3- MENU AULAS
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

                        //4- MENU PROFESORES
                    case 4:

                        Console.WriteLine("\t --- UNI-APP --- ");
                        Console.WriteLine("\t  ");
                        Console.WriteLine(" 1- Ver profesores ");
                        Console.WriteLine(" 2- Dar de alta ");
                        Console.WriteLine(" 3- Dar de baja ");
                        Console.WriteLine(" 4- Modificar ");
                        Console.WriteLine(" 5- Volver al Menu principal ");


                        break;


                        //5- CAMBIAR ASIGNATURA POR PROFESOR
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
