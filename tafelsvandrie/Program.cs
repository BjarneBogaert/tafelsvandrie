using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tafelsvandrie
    class Program
    {
        static void Main(string[] args)
        {
            //declaraties
            int num;
            
            //input
            //vraag naar het getal 
            Console.Write("Enter the Number :");
            num = Convert.ToInt32(Console.ReadLine());
            
            //processing
            //iteraties en stel een limiet in voor de maaltafel
            for (int i = 1; i <= 10; i++)
            {
                //output
                //toon de tafels va nhet geven getal tot het tiental
                Console.WriteLine("{0}*{1}={2}", num, i, num * i);
            }
            Console.ReadLine();

        //afsluiting
        Console.ReadLine();
        Console.WriteLine("Druk op enter om af te sluiten...");
        Console.ReadLine();
        }
    }
}
