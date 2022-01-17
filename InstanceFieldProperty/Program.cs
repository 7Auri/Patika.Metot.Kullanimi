using System;

namespace InstanceFieldProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Zorbey";
            calisan1.Soyad = "Welkey";
            calisan1.No = 7775647;
            calisan1.Departman = "IT";

            calisan1.CalisanBilgileri();
            Console.WriteLine("-----------------------------------");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Auri";
            calisan2.Soyad = "Boo";
            calisan2.No = 5888421;
            calisan2.Departman = "IK";

            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;


        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0} ",Ad);
            Console.WriteLine("Çalışan Soyadı:{0} ", Soyad);
            Console.WriteLine("Çalışan No:{0} ", No);
            Console.WriteLine("Çalışanın Departmanı:{0} ", Departman);
        }
    }
}
