using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Curso
    {
        private List<Asignatura> asignaturas = new List<Asignatura>();
        private List<Alumno> alumnos = new List<Alumno>();
        private Aula aula;
        private string cur;
        public string Cur { get { return cur; } set { cur = value; } }
        private string division; 
        public string Division { get { return division; } set { division = value; } }


        public List<Asignatura> getAsignaturas()
        {
            return this.asignaturas;
        }

        public List<Alumno> getAlumnos()
        {
            return this.alumnos;
        }

        public bool inscribirAlumno(Alumno alum)
        {
            alumnos.Add(alum);
            return true;
        }






    }
}
