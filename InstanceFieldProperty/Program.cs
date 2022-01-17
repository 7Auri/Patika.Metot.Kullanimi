using System;

namespace InstanceFieldProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Zorbey","Welkey", 7775647,"IT");
           
            calisan1.CalisanBilgileri();
            Console.WriteLine("-----------------------------------");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Auri";
            calisan2.Soyad = "Boo";
            calisan2.No = 5888421;
            calisan2.Departman = "IK";

            calisan2.CalisanBilgileri();

            Console.WriteLine("-----------------------------------");
            Calisan calisan3 = new Calisan("Arya", "Black");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad,string soyad,int no,string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan() { }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0} ",Ad);
            Console.WriteLine("Çalışan Soyadı:{0} ", Soyad);
            Console.WriteLine("Çalışan No:{0} ", No);
            Console.WriteLine("Çalışanın Departmanı:{0} ", Departman);
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            
        }

    }
}
