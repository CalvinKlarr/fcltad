using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Profesor:Usuario
    {
        private List<Asignatura> asig;

        public Profesor(string name, string lname, int doc, int phone, string direcc, List <Asignatura> asign )
        {
            this.nombre = name;
            this.apellido = lname;
            this.dni = doc;
            this.tel = phone;
            this.direc = direcc;    
            this.asig = asign = new List<Asignatura>();

        }

        public Profesor()
        {

        }



    }
}
