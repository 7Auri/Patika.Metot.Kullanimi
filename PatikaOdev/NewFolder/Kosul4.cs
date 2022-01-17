using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaOdev.NewFolder
{
    class Kosul4
    {
        static void Main(string[] args)
        {
            string cumle;
            Console.WriteLine("Bir Cümle Yazınız");
            cumle = Console.ReadLine();

            string[] splitCumle = cumle.Split(" ");
            char[] harf = cumle.ToCharArray();


            int topKeli = 0;
            int topHarf = 0;

            foreach (var item in splitCumle)
            {
                topKeli++;
            }
            foreach (var item in harf)
            {
                topHarf++;
            }


            Console.WriteLine("Toplam Kelime Sayısı: ");
            Console.WriteLine(topKeli);
            Console.WriteLine("Toplam Harf Sayısı: ");
            Console.WriteLine(topHarf);
            Console.WriteLine("Cümleniz: ");
            Console.WriteLine(cumle);
        }
    }
}
