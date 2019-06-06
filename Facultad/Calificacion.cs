using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Calificacion
    {
        private int[] parciales = new int[2];

        private int[] recup = new int[2];

        public int[] getParciales() { return parciales; }

        public void SetParciales(int notas)
        {
            foreach (int i in parciales)
            {
                System.Console.Write("{0} ", notas);
            }
        }

        public int[] getRecup(){ return recup; }

        public void setRecup(int notes) {
            foreach (int i in recup)
            {
                System.Console.Write("{0} ", notes);
            }
        }


    }

}
