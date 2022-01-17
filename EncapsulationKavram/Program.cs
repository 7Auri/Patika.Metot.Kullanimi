using System;

namespace EncapsulationKavram
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Berk";
            ogrenci.Soyisim = "Yeşilalioğlu";
            ogrenci.No = 4426;
            ogrenci.Sinif = 1;
            ogrenci.OgrenciBilgileriGetir();
            /* ogrenci.SinifAtlat();*/
            ogrenci.SinifDüsür();
            ogrenci.OgrenciBilgileriGetir();
            Ogrenci ogrenci2 = new Ogrenci(777,"Arya","Black",7 );
            ogrenci2.OgrenciBilgileriGetir();
            ogrenci2.SinifAtlat();
            ogrenci2.OgrenciBilgileriGetir();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int no;
        private int sinif;


        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int No { get => no; set => no = value; }
        public int Sinif
        {
            get => sinif;
            set {
                if (value < 1)
                {
                   
                    Console.WriteLine("Bu İmkansız!!!! Daha Fazla Düşemez");
                    sinif = 1;
                }
                else sinif = value;
                
            }
        }
        public Ogrenci(int no, string isim, string soyisim, int sinif)
        {
            No = no;
            Isim = isim;
            Soyisim = soyisim;
            Sinif = sinif;
        }

        public Ogrenci() {}

        public void OgrenciBilgileriGetir()
        {
            Console.WriteLine("***********Öğrenci Bilgileri*******");
            Console.WriteLine("Öğrenci Adı      : {0}",this.Isim);
            Console.WriteLine("Öğrenci Soyadı   : {0}", this.Soyisim);
            Console.WriteLine("Öğrenci No       : {0}", this.No);
            Console.WriteLine("Öğrenci Sınıf    : {0}", this.Sinif);

        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDüsür()
        {

            this.Sinif = this.Sinif - 1;
           
        }

    }
}
