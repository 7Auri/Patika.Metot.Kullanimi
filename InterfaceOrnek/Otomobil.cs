namespace InterfaceOrnek
{
    public abstract class Otomobil
    {
        public int KacTekerlek()
        {
            return 4;
        }

        public virtual Renk RenkNe()
        {
            return Renk.Beyaz;
        }

        public abstract Marka HangiMarka();
        

    }
}
