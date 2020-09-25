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
            egyikHarcos.Megkuzd(new Harcos("Gyenge Gábor", 1));
        }
    }
}
