using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg a nevét a harcosának: ");
            string harcosnev = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Milyen státusza legyen? (1-3): ");
            int status = Convert.ToInt32(Console.ReadLine());
           Harcos foHarcos = new Harcos(harcosnev, status);
          
            List<Harcos> harcosLista = new List<Harcos>();
           Harcos kihivo2= new Harcos("Turbo Titán", 2);
           Harcos kihivo3 = new Harcos("Vas Ember", 3);
           Harcos kihivo4 = new Harcos("Kovács Ádám", 1);

            harcosLista.Add(kihivo2);
            harcosLista.Add(kihivo3);
            harcosLista.Add(kihivo4);

            Console.WriteLine(kihivo2);
            Console.WriteLine(kihivo3);
            Console.WriteLine(kihivo4);
            
           //egyikHarcos.Megkuzd(new Harcos("Gyenge Gábor", 1));
        }
    }
}
