using System;

namespace String_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersi miz CSharp,Hoş geldi niz";
            string degisken2 = "Dersimiz CSharp";
            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper,ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            // Concat
            Console.WriteLine(String.Concat(degisken, " Ben Büşra"));

            //Compare, CompareTo 
            Console.WriteLine(degisken.CompareTo(degisken2)); // 0 eşitse, 1 değişken daha uzunsa, -1 değişken2 daha uzunsa
            Console.WriteLine(String.Compare(degisken, degisken2, true));


            // Contains /Değişkenin içinde değişken2 var mı?
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Hoşgeldiniz"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0, "Büşra "));

            //PadLeft,PadRight
            Console.WriteLine(degisken+degisken2.PadLeft(30));
            Console.WriteLine(degisken.PadRight(50) + degisken2.PadLeft(30));


            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(3,5));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ",""));

            //Split
            Console.WriteLine(degisken.Split(" ")[1]);

            //Substring
            Console.WriteLine(degisken.Substring(7));
            Console.WriteLine(degisken.Substring(7,11));
        }
    }
}
