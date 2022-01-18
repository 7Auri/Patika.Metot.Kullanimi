using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek
{
    public class X5 : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.BMW;
        }

        public int KacTekerlek()
        {
            return 4;
        }

        public Renk RenkNe()
        {
            return Renk.Gri;
        }
    }
}
