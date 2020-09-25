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
           Harcos egyikHarcos = new Harcos("Erős János", 1);
          
            List<Harcos> harcosLista = new List<Harcos>();
           Harcos kihivo2= new Harcos("Turbo Titán", 2);
           Harcos kihivo3 = new Harcos("Vas Ember", 3);
           Harcos kihivo4 = new Harcos("Kovács Ádám", 1);
            harcosLista.Add(kihivo2);
            harcosLista.Add(kihivo3);
            harcosLista.Add(kihivo4);
            Console.WriteLine(egyikHarcos);
            Console.WriteLine(kihivo2);
            Console.WriteLine(kihivo3);
            Console.WriteLine(kihivo4);
            
           //egyikHarcos.Megkuzd(new Harcos("Gyenge Gábor", 1));
        }
    }
}
