using System;

namespace Static_Sınıf_ve_Üyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Berk","Yeşilalioğlu","IT");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Büşra", "Yeşilalioğlu", "ARGE");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Islem.Topla(52, 7);
            Console.WriteLine("Toplam: {0}", Islem.Topla(52, 7));
            Islem.Cikar(52, 7);
            Console.WriteLine("Çıkarma: {0}", Islem.Cikar(52, 7));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;/* set => calisanSayisi = value; */}

        private string Isim;

        private string Soyisim;

        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi ++;
        }


    }

    static class Islem
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
