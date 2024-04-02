using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMalliDemo
{
    public class AjoneuvoTehdas
    {
        public static IAjoneuvo LuoUusi(string tyyppi)
        {
            if (tyyppi == "auto")
            {
                Auto auto = new();
                return auto;
            }
            else if (tyyppi == "mp")
            {
                Moottoripyörä mp = new();
                return mp;
            }
            else
            {
                throw new Exception("Väärä tyyppi!");
            }
        }
    }
}
