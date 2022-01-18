using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek
{
    public class NewX5 : Otomobil
    {
        public override Marka HangiMarka()
        {
            return Marka.BMW;
        }

        public override Renk RenkNe()
        {
            return Renk.Gri;
        }

    }
}
