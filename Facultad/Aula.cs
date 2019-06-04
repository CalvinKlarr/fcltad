using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Aula
    {
        private int id { get { return id; } set { id = value; } }
        private int capacidad { get { return capacidad; } set { capacidad = value;} }
        private bool conexionARed { get {return conexionARed; } set {conexionARed = value; } }
        private bool proyeccion { get { return proyeccion; } set { proyeccion = value; } }

        public Aula(int i, int cap, bool con, bool proy)
        {
            this.id = i;
            this.capacidad = cap;
            this.conexionARed = con;
            this.proyeccion = proy;
        }






    }
}
