using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayListe
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList liste = new ArrayList();
           /* liste.Add("Zorbey");
            liste.Add(7);
            liste.Add(false);
            liste.Add('B');
*/
            //İçerisindeki verilere erişme
            /*Console.WriteLine(liste[1]);*/
            //Tüm elemanlara erişim
           /* foreach (var item in liste)
                Console.WriteLine(item);
*/
            //AddRange Toplu eleman ekleme
            Console.WriteLine(" -----AddRange----- ");
            /*string[] renkler = { "Turkuaz", "Siyah", "Gri" };*/
            List<int> sayilar = new List<int>() { 15, 21, 125, 777, 9, 42, 8 };
            /*liste.AddRange(renkler);*/
            liste.AddRange(sayilar);

            foreach (var item in liste)
                Console.WriteLine(item);

            //Sort Sıralama
            Console.WriteLine(" -----Sort----- ");
             liste.Sort();  
            foreach (var item in liste)
                Console.WriteLine(item);

            //BinarySearch
            Console.WriteLine(" -----BinarySearch------ ");
            Console.WriteLine(liste.BinarySearch(777));

            //Reverse
            Console.WriteLine(" -----Reverse----- ");
            liste.Reverse();
            foreach (var item in liste)
                Console.WriteLine(item);

            //Clear
            Console.WriteLine(" -----Clear----- ");
            liste.Clear();

            foreach (var item in liste)
                Console.WriteLine(item);
        }
    }
}