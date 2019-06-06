using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Main
    {
        static void main()
        {



            Console.WriteLine("\t --- Bienvenido a UNI-APP --- ");
            Console.WriteLine("\t --- Bienvenido a UNI-APP --- ");
            Console.WriteLine("\t --- Bienvenido a UNI-APP --- ");

            int caseSwitch=Convert.ToInt32(Console.ReadLine());
                              

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }




        }
    }

}
