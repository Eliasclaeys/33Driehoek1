using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driehoek1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Maak dit na
             * oef 1

                *
                **
                ***
                ****
                *****
             */

            //Declarations
            int hoogte, herhaling, Sterretjes_teller;

            //VRAAG: hoogte
            Console.Write("Hoe hoog moet de driehoek zijn ");
            hoogte = int.Parse(Console.ReadLine());

            Sterretjes_teller = (hoogte - 1) / 2;

            //HERHAAL: als hoogte > dan 0
            for(herhaling = 1; herhaling < hoogte; herhaling+=1)
            {
                for(Sterretjes_teller = 0; Sterretjes_teller < hoogte; Sterretjes_teller++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Wachten...
            Console.WriteLine();
            Console.Write("Druk op enter om af te sluiten ");
            Console.ReadLine();

        }
    }
}
