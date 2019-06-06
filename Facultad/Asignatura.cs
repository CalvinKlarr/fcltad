using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Asignatura
    {
        private string asignatura { get { return asignatura; } set { asignatura = value; } }
        private List<Asignatura> correlativas = new List<Asignatura>();
        //to-do, implementar revision prof
        private List<Profesor> profesores = new List<Profesor>();
        //to-do implementar revision calificaciones
        private Dictionary<string, Calificacion> calificaciones = new Dictionary<string, Calificacion>();

        private Curso curso = new Curso();

        public Asignatura(string asig, List<Asignatura> asigs, List<Profesor> profes, Dictionary<string,Calificacion> califs, Curso curs)
        {
            this.asignatura = asig;
            this.correlativas = asigs;
            this.profesores = profes;
            this.calificaciones = califs;
            this.curso = curs;

        }

        public string verCorrelativas()
        {
            string corr="";

            foreach(var a in correlativas){
                corr += a.asignatura+" ";
            }
            return corr;
        }


    }
}
