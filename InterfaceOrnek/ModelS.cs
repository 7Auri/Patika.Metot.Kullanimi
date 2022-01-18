namespace InterfaceOrnek
{
    public class ModelS : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.Tesla;
        }

        public int KacTekerlek()
        {
            return 4;
        }


            public Renk RenkNe()
            {
            return Renk.Siyah;
            }
        
    }
}