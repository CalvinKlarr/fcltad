﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Alumno:Usuario
    {
        private Curso curso { get { return curso; } set { curso = value; } }
        private int id;
        public List<string> aprobadas = new List<string>();
        public int Id { get { return id; } set { id = value; } }

        public Alumno(string name, string lname, int doc, int phone, string direcc, int id, Curso curse)
        {
            this.nombre = name;
            this.apellido = lname;
            this.dni = doc;
            this.tel = phone;
            this.direc = direcc;
            this.id = id;
            
            this.curso = curse;

        }

        public override string ToString()
        {
            return "Nombre: "+this.nombre+"\nApellido: "+this.apellido+
                "\nDireccion: "+this.direc+"\nDNI: "+this.dni+"\nTelefono: "+this.Tel+"\nLegajo: "+this.Id+"\n";
        }




    }
}
