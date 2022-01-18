using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cuma);
            int sicaklik = 22;
            if (sicaklik <= ((int)HavaDurumu.Normal))
            {

                Console.WriteLine("Hava Soğuk");
            }
            else if (sicaklik >= ((int)HavaDurumu.Sicak))
            {
                Console.WriteLine("Hava Çok Sıcak");
            }
            else if (sicaklik>=(int)HavaDurumu.Normal && sicaklik< (int)HavaDurumu.Cok_Sicak)
            {
                Console.WriteLine("Hava Çok Güzel");
            }
        }
    }

    enum Gunler
    {
        Pazartesi=1,
        Sali,
        Carsamba,
        Persembe=77,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sicak=25,
        Cok_Sicak=30,
    }
}
