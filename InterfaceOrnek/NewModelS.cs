using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek
{
    public class NewModelS : Otomobil
    {
        public override Marka HangiMarka()
        {
            return Marka.Tesla;
        }

        public override Renk RenkNe()
        {
            return Renk.Siyah;
        }


    }
}
