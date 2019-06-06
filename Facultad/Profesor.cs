using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Profesor:Usuario
    {
       private Asignatura asig { get { return asig; } set { asig = value; } }
        private int id { get { return id; } set { id = value; } }

        public Profesor(string name, string lname, int doc, int phone, string direcc, int id, Asignatura asign )
        {
            this.nombre = name;
            this.apellido = lname;
            this.dni = doc;
            this.tel = phone;
            this.direc = direcc;
            this.id = id;
            this.asig = asign;

        }




    }
}
