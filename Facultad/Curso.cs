using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Curso
    {
        private Asignatura[] asignaturas;
        private List<Alumno> alumnos;
        private Aula aula;
        private string cur;
        public string Cur { get { return cur; } set { cur = value; } }
        private string division; 
        public string Division { get { return division; } set { division = value; } }

        public Curso (Aula aula, string curs, string division)
	    {
            asignaturas = new Asignatura[5];
            alumnos = new List<Alumno>();
            this.aula = aula;
            this.cur = curs;
            this.division = division;

	    }


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

        public Aula getAula()
        {
            return this.aula;
        }

        public void setAula(Aula aula)
        {
            this.aula = aula;
        }






    }
}
