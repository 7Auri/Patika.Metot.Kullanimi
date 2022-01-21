using System;
using System.Collections.Generic;

namespace Generic_Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(777);
            sayiListesi.Add(27);
            sayiListesi.Add(7);
            sayiListesi.Add(888);
            sayiListesi.Add(11);
            sayiListesi.Add(19);
            sayiListesi.Add(5);

            List<string> stringListe = new List<string>();
            stringListe.Add("Arya");
            stringListe.Add("Zorbey");
            stringListe.Add("Turkuaz");
            stringListe.Add("Auri");
            stringListe.Add("Enerji");


            // Count
            Console.WriteLine(stringListe.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }


            foreach (var str in stringListe)
            {
                Console.WriteLine(str);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            stringListe.ForEach(str => Console.WriteLine(str));


            //Listeden Eleman Çıkarma
            sayiListesi.Remove(19);
            stringListe.Remove("Turkuaz");
            sayiListesi.RemoveAt(1);


            //Liste İçerisinded Arama
            if (sayiListesi.Contains(777))
            {
                Console.WriteLine("777 var listede");
            }

            //Eleman İle Indexe Erişme
            Console.WriteLine(stringListe.BinarySearch("Arya"));


            //Diziyi List'e Çevirme

            string[] hayvanlar = { "Kedi", "Köpek", "Yılan", "Koala" };
            List<string> hayvanList = new List<string>(hayvanlar);


            //List Temizleme
            hayvanList.Clear();

            //List İçerisinde Nesne Tutma
            List<Person> newPerson = new List<Person>();


            Person newPerson1 = new Person();
            newPerson1.Name = "Büşra";
            newPerson1.SubName = "Yeşilalioğlu";
            newPerson1.Age = 27;

            Person newPerson2 = new Person();
            newPerson2.Name = "Taha Berk";
            newPerson2.SubName = "Yeşilalioğlu";
            newPerson2.Age = 22;

            newPerson.Add(newPerson1);
            newPerson.Add(newPerson2);

            List<Person> yeniList = new List<Person>();
            yeniList.Add(new Person()
            {
                Name = "Arya",
                SubName = "Yeşilalioğlu",
                Age = 2
            });

            foreach ( var person in newPerson)
            {
                Console.WriteLine("Kullanıcı Adı: "+ person.Name);
                Console.WriteLine("Kullanıcı SoyAdı: " + person.SubName);
                Console.WriteLine("Kullanıcı Yaşı: " + person.Age);
            }
        }
    }

    public class Person
    {
        private string name;
        private string subname;
        private int age;

        public string Name { get => name; set => name = value; }
        public string SubName { get => subname; set => subname = value; }
        public int Age { get => age; set => age = value; }
    }
}
