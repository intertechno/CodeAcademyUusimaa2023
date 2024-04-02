using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMalliDemo
{
    public class Moottoripyörä : IAjoneuvo
    {
        public void Käynnistä()
        {
            Console.WriteLine("Moottoripyörän moottori on nyt käynnissä.");
        }
    }
}
