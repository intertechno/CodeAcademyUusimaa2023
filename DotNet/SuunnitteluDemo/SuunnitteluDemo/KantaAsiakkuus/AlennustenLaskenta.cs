using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuunnitteluDemo.Kantaasiakkuus
{
    public enum KantaAsiakasTaso
    {
        Hopea,
        Kulta,
        Platina
    }

    public class AlennustenLaskenta
    {
        public int LaskeAlennusProsentti(KantaAsiakasTaso asiakastaso)
        {
            if (asiakastaso == KantaAsiakasTaso.Kulta)
            {
                return 10;
            }
            else if (asiakastaso == KantaAsiakasTaso.Platina)
            {
                return 20;
            }

            throw new ApplicationException("Virheellinen kanta-asiakkuustaso!");
        }
    }
}
