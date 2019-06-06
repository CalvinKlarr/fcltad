using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class ProgramControl
    {
        private List<Curso> cursos = new List<Curso>();
        private List<Alumno> alumnos = new List<Alumno>();
        private List<Asignatura> asignaturas = new List<Asignatura>();
        

        public void inscribir(int id, string asignatura)
        {
            Curso cursop = new Curso();
            Alumno alum;
            List<string> correlativas = new List<string>();


            foreach (var c in cursos)
            {
                
                foreach(var at in c.getAsignaturas())
                {
                    if (at.Asign.Equals(asignatura))
                    {
                        cursop = c;
                        correlativas = at.verCorrelativas();
                    }
                }
            }
            
            
                foreach (var a in alumnos)
                {
                    if (Utils.checkCorrel(correlativas,a )) {
                        if (a.Id == id)
                        {
                            alum = new Alumno(a.Nombre, a.Apellido, a.Dni, a.Tel, a.Direc, a.Id, cursop);
                        }
                }

                }
            

        }



    }
}
