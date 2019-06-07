using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class ProgramControl
    {
        private Curso[] cursos;
        private List<Alumno> alumnos;
        private Asignatura[] asignaturas;
        private Aulas[] aulas = new Aula[8];

        public ProgramControl ()
	    {
            cursos = new Curso[] {new Curso(aulas[0],"primer cuatrimestre","mañana"), 
                                   new Curso(aulas[1],"primer cuatrimestre","tarde"), 
                                    new Curso(aulas[2],"primer cuatrimestre","noche"),
                                    new Curso(aulas[3],"segundo cuatrimestre","mañana"),
                                    new Curso(aulas[4],"segundo cuatrimestre","tarde"),
                                    new Curso(aulas[5],"segundo cuatrimestre","noche"),
                                    new Curso(aulas[6],"tercer cuatrimestre","tarde"),
                                    new Curso(aulas[7],"cuarto cuatrimestre","noche")};
            asignaturas = new Asignatura[] {new Asignatura("programacion 1", null),
                                            new Asignatura("sistema de procesamiento de datos",null), 
                                            new Asignatura("matematica",null),
                                            new Asignatura("ingles 1",null),
                                            new Asignatura("laboratorio de computacion 1",null),
                                            new Asignatura("programacion 2",List<Asignatura> asi = new List<Asignatura> {new Asignatura("programacion 1",null), new Asignatura("laboratorio de computacion 1",null)}),
                                            new Asignatura("arquitectura y sistemas operativos",List<Asignatura> asi = new List<Asignatura> {new Asignatura("sistema de procesamiento de datos",null)}),
                                            new Asignatura("estadistica",List<Asignatura> asi = new List<Asignatura> {new Asignatura("matematicas",null)}),
                                            new Asignatura("ingles 2",List<Asignatura> asi = new List<Asignatura> {new Asignatura("ingles 1",null)}),
                                            new Asignatura("laboratorio de computacion 2",List<Asignatura> asi = new List<Asignatura> {new Asignatura("programacion 1",null), new Asignatura("laboratorio de computacion 1",null)}),
                                            new Asignatura("metodologia de la investigacion",null),
                                            new Asignatura("programacion 3",List<Asignatura> asi = new List<Asignatura> {new Asignatura("programacion 2",null), new Asignatura("laboratorio de computacion 2",null)}),
                                            new Asignatura("organizacion contable de la empresa",List<Asignatura> asi = new List<Asignatura> {new Asignatura("matematicas",null)}),
                                            new Asignatura("organizacion empresarial",List<Asignatura> asi = new List<Asignatura> {new Asignatura("estadistica",null)}),
                                            new Asignatura("elementos de la investigacion operativa",List<Asignatura> asi = new List<Asignatura> {new Asignatura("matematicas",null)}),
                                            new Asignatura("laboratorio de computacion 3",List<Asignatura> asi = new List<Asignatura> {new Asignatura("programacion 2",null), new Asignatura("laboratorio de computacion 2",null)}),
                                            new Asignatura("metodologia de sistemas",List<Asignatura> asi = new List<Asignatura> {new Asignatura("programacion 3",null), new Asignatura("laboratorio de computacion 3",null), new Asignatura("metodologia de la investigacion",null), new Asignatura("organizacion contable de la empresa",null), new Asignatura("organizacion empresarial",null)}),
                                            new Asignatura("diseño y administracion de base de datos",List<Asignatura> asi = new List<Asignatura> {new Asignatura("programacion 3",null), new Asignatura("laboratorio de computacion 3",null)}),
                                            new Asignatura("legislacion",null),
                                            new Asignatura("laboratorio de computacion 4",List<Asignatura> asi = new List<Asignatura> {new Asignatura("programacion 3",null), new Asignatura("laboratorio de computacion 3",null)})};


	    }
        

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
