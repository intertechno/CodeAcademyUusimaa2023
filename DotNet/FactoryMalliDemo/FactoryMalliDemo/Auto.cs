using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMalliDemo
{
    public class Auto : IAjoneuvo
    {
        public void Käynnistä()
        {
            Console.WriteLine("Auton moottori on nyt käynnissä.");
        }
    }
}
