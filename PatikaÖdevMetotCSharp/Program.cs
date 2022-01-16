using System;

namespace PatikaÖdevMetotCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            /*Console.WriteLine(a + b);*/

            int sonuc= Topla(a, b);
            /*Console.WriteLine(sonuc);*/

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));
            /*int sonuc2 = ornek.ArttirVeTopla( a,  b);  referans kullanmadan önce sonuç bu şekilde 5  çıkıyordu */
            int sonuc2 = ornek.ArttirVeTopla(ref a,ref b); // Referansla birlikte yeni değerleri alıyor ve 2 arttırma ile 7 oluyor.
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
        }

     static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }

    class Metotlar
    {
      public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

       /* public int ArttirVeTopla( int deger1,  int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;

        }*/
        public int ArttirVeTopla( ref int deger1,ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;

        }
    }
}
