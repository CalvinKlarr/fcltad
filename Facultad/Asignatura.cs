using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Asignatura
    {
        private string asign; 
        public string Asign { get { return asign; } set { asign = value; } }
        private List<string> correlativas = new List<string>();
        
        public List<Profesor> Profesores = new List<Profesor>();
        private Dictionary<Alumno, Calificacion> calificaciones = new Dictionary<Alumno, Calificacion>();
        private Curso curso = new Curso();
        private List<Alumno> alumnos = new List<Alumno>();

        public Asignatura(string asig, List<string> asigs, List<Profesor> profes, Dictionary<Alumno,Calificacion> califs, Curso curs)
        {
            this.asign = asig;
            this.correlativas = asigs;
            this.profesores = profes;
            this.calificaciones = califs;
            this.curso = curs;

        }

        public List<string> verCorrelativas()
        {
            return correlativas;
        }

        public List<Alumno> getAlumnos()
        {
            return alumnos;
        }

        public Dictionary<Alumno,Calificacion> getCalificaciones()
        {
            return calificaciones;
        }

        public bool addCalificacion(Alumno alum, Calificacion calif)
        {
            calificaciones.Add(alum,calif);
            return true;
        }

        public Calificacion getCalificacion(Alumno alum)
        {
            Calificacion calif = null;
            foreach (var a in calificaciones)
            {
                if (a.Key.Id == alum.Id)
                {
                    calif = a.Value;
                }
            }
            return calif;
        }

        public List<Profesor> getProfesores()
        {
            return this.profesores;
        }

        public void addProfesor(Profesor profe)
        {
            profesores.Add(profe);
        }

    }
}
