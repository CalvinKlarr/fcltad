using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class ProgramControl
    {
        private Curso[] cursos = new Curso[8];
        private List<Alumno> alumnos = new List<Alumno>();
        private Asignatura[] asignaturas = new Asignatura[21];
        

        public bool inscribir(int id, string asignatura)
        {
            Alumno alum = Utils.findAlumno(id,this.alumnos);
            List<string> correlativas = Utils.findCorrelativas(asignaturas, asignatura);
            Curso cur = Utils.findCurso(cursos,asignatura);

            if (Utils.checkCorrel(correlativas,alum))
            {
                cur.inscribirAlumno(alum);
                return true;
            }
            return false;
         
        }

        public List<Alumno> verAlumnosPorCurso(string curso)
        {
            List<Alumno> alum = null;
            foreach (var c in cursos)
            {
                if (c.Cur.Equals(curso))
                {
                    alum = c.getAlumnos();
                }
            }
            return alum;

        }

        public List<Alumno> verAlumnosPorMateria(string asignatura)
        {
            List < Alumno > alum = null;
            foreach (var a in asignaturas)
            {
                if (a.Asign.Equals(asignatura))
                {
                    alum = a.getAlumnos();
                }
            }

            return alum;
        }

        public Dictionary<Alumno,Calificacion> verCalificaciones(string asignatura)
        {
            Asignatura asig = Utils.findAsignatura(asignaturas,asignatura);

            return asig.getCalificaciones();
        }

        public bool subirCalificaciones(int id, Calificacion calif, string asign)
        {
            Alumno alum = Utils.findAlumno(id, alumnos);
            Asignatura asig = Utils.findAsignatura(asignaturas, asign);

            if (asig.addCalificacion(alum, calif))
            {
                return true;
            }
            return false;
        }

        public Calificacion getCalificacion(int id, string asignatura)
        {
            Alumno alum = Utils.findAlumno(id,alumnos);
            Asignatura asig = Utils.findAsignatura(asignaturas, asignatura);
            Calificacion calif = asig.getCalificacion(alum);
            return calif;
        }

        public bool bajaAlumno(int id)
        {
            Alumno alum = Utils.findAlumno(id,alumnos);

            alumnos.Remove(alum);
            return true;
        }

        public Alumno getAlumno(int id)
        {
            Alumno alum = Utils.findAlumno(id,alumnos);
            return alum;
        }

        public Aula[] verAulas()
        {
            Aula[] aulas = new Aula[8];
            for(int i = 0; i<8; i++)
            {
                aulas[i] = cursos[i].getAula();
            }
            return aulas;
        }

        public Aula getAula(string curso)
        {
            Aula aula = Utils.findCurso(curso, cursos).getAula();
            return aula;
        }

        public bool cambiarAula(string curso, Aula aula)
        {
            Curso cur = Utils.findCurso(curso, cursos);
            cur.setAula(aula);
            for(int i=0; i < 8; i++)
            {
                if (cursos[i].Cur.Equals(curso))
                {
                    cursos[i] = cur;
                }
            }
            return true;
        }

        public List<Profesor> verProfesores()
        {
            List<Profesor> profesores = new List<Profesor>();
            foreach(var a in asignaturas)
            {
                profesores.AddRange(a.getProfesores());
            }
            return profesores;
        }

        public bool altaProfesor(Profesor profe, string asignatura)
        {
            Asignatura asig = Utils.findAsignatura(asignaturas, asignatura);
            asig.addProfesor(profe);
            return true;

        }

        public bool bajaProfesor(int dni, string asignatura)
        {
            Profesor profe = Utils.findProfesor(asignaturas, dni);
            foreach (var a in asignaturas)
            {
                foreach(var p in a.Profesores)
                {
                    if(p.Dni == dni)
                    {
                        a.Profesores.Remove(profe);
                    }
                }
            }

            return true;
        }

        public Profesor getProfesor(int dni){
            Profesor profesor = Utils.findProfesor(asignaturas, dni);
            return profesor;
        }



    }
}
