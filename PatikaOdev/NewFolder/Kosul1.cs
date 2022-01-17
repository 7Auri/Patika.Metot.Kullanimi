using System;

namespace PatikaOdev
{
    class Kosul1
    {

        static void Main(string[] args)
        {

            //Koşul 1
            for (int k = 0; k < 4; k++)
            {


                int sayi;

                Console.WriteLine("Pozitif Bir Sayı Giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
               
                

                    if (sayi > 0)
                    {
                        int[] array = new int[sayi];
                        for (int i = 0; i < sayi; i++)
                        {

                            Console.WriteLine("Sayı giriniz:");

                            int sayi2 = Convert.ToInt32(Console.ReadLine());
                            array[i] = sayi2;

                        }
                        Console.WriteLine("Girdiğiniz Çift Sayılar: ");
                        for (int j = 0; j < sayi; j++)
                        {
                            if (array[j] % 2 == 0)
                            {

                                Console.WriteLine(array[j]);
                            }
                        }
                        break;
                    }


                
                else
                {
                    Console.WriteLine("Girdiğiniz Sayı Pozitif Değil");

                }
            }

        } //Koşul1 SON!!
    }
}

