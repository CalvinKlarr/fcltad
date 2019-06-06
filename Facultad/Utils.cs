using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    static class Utils
    {
        public static bool checkCorrel(List<string> correlativas, Alumno alumno)
        {
            int num = correlativas.Count, flag = 0;
            foreach (var cor in correlativas)
            {
                foreach (var apr in alumno.aprobadas)
                {
                    if (apr.Equals(cor)) {
                        flag++;
                    }
                }
            }
            if (flag == num)
            {
                return true;
            }
            return false;
        }

        public static Alumno findAlumno(int id, List<Alumno> alumnos)
        {
            Alumno alum = null;
            foreach (var a in alumnos)
            {
                if(a.Id == id)
                {
                    alum = a;
                }
            }
            return alum;
        }

        public static List<string> findCorrelativas(Asignatura[] asignaturas, string asig)
        {
            List<string> correlativas = null;
            foreach (var a in asignaturas)
            {
                if (a.Asign.Equals(asig))
                {
                    correlativas = a.verCorrelativas();
                }
            }

            return correlativas;



        }

        public static Curso findCurso(Curso[] cursos, string asignatura)
        {
            Curso cur = null;
            foreach (var c in cursos)
            {
                foreach(var a in c.getAsignaturas())
                {
                    if (a.Asign.Equals(asignatura))
                    {
                        cur = c;
                    }
                }

            }

            return cur;

        }

        public static Asignatura findAsignatura(Asignatura[] asignaturas, string asignatura)
        {
            Asignatura asig = null;
            foreach (var a in asignaturas)
            {
                if (a.Asign.Equals(asignatura))
                {
                    asig = a;
                }
            }
            return asig;

        }
    }
}
