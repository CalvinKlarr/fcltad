using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Alumno:Usuario
    {
        private Curso curso { get { return curso; } set { curso = value; } }
        private Calificacion calif { get { return calif; } set { calif= value; } }

        public Alumno(string name, string lname, int doc, int phone, string direcc, int id, Calificacion califi, Curso curse)
        {
            this.nombre = name;
            this.apellido = lname;
            this.dni = doc;
            this.tel = phone;
            this.direc = direcc;
            this.id = id;
            this.calif = califi;
            this.curso = curse;

        }




    }
}
