using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaOdev.NewFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac;

            for (int m = 0; m < 4; m++)
            {
                Console.WriteLine("Pozitif Bir Sayı Giriniz: ");
                sayac = Convert.ToInt32(Console.ReadLine());


                if (sayac > 0)
                {

                    string[] array = new string[sayac];

                    for (int i = 0; i < sayac; i++)
                    {


                        Console.WriteLine("Kelime Giriniz: ");
                        array[i] = Convert.ToString(Console.ReadLine());
                    }
                    Console.WriteLine("Girdiğiniz Kelimeler Sondan Başa Doğru: ");
                    Array.Reverse(array);
                    for (int i = 0; i < sayac; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Pozitif Sayı Değil!! ");
                }
            }
        }
    }
}
