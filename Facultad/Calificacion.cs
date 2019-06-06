using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Calificacion
    {
        private int[] parciales = new int[3];

        private int[] recup = new int[2];



        public int[] TotalParciales(){ return parciales; }

        public int getParciales(int numParcial)
        {
            switch (numParcial)
            {
                case 1: return parciales[1];  break;
                case 2: return parciales[2]; break;
                case 3: return parciales[3]; break;

            }
            return 0;
        }


        public void  setParciales(int numParcial, int nota)
        {

            switch (numParcial)
            {
                case 1: parciales[1] = nota; break;
                case 2: parciales[2] = nota; break;
                case 3: parciales[3] = nota; break;

            }
        }

       // public int[] getTotalRecups(){ return recup; }

        public int getRecup(int numRecup)
        {
            switch (numRecup)
            {
                case 1: return recup[1]; break;
                case 2: return recup[2]; break;
            }
            return 0;
        }


        public void setRecup(int numRecup, int nota)
        {

            switch (numRecup)
            {
                case 1: recup[1] = nota; break;
                case 2: recup[2] = nota; break;
              
            }
        }


    }

}
