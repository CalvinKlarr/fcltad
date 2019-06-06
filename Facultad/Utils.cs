using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    static class Utils
    {
        public static bool checkCorrel(List<string> correlativas, Alumno alumno)
        {
            int num = correlativas.Count, flag = 0;
            foreach (var cor in correlativas)
            {
                foreach (var apr in alumno.aprobadas)
                {
                    if (apr.Equals(cor)) {
                        flag++;
                    }
                }
            }
            if (flag == num)
            {
                return true;
            }
            return false;
        }
    }
}
