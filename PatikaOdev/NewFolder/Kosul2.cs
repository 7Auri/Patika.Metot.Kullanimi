using System;

namespace PatikaOdev
{
    class Kosul2
    {
        static void Main(string[] args)
        {
            for (int s = 0; s < 4; s++)
            {
                int poz1;
                int poz2;

                Console.WriteLine("Yeni Pozitif Bir Sayı Giriniz: ");
                poz1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pozitif Bir Sayı Giriniz: ");
                poz2 = Convert.ToInt32(Console.ReadLine());

                if (poz1 > 0 && poz2 > 0)
                {



                    int[] array = new int[poz1];

                    for (int i = 0; i < poz1; i++)
                    {

                        Console.WriteLine("Sayı giriniz:");


                        array[i] = Convert.ToInt32(Console.ReadLine());

                    }

                    Console.WriteLine("Girdiğiniz Sayılar Eşit? veya Tam Bölünür: ");

                    for (int k = 0; k < poz1; k++)
                    {
                        if (array[k] == poz2 || poz2 % array[k] == 0)
                        {

                            Console.WriteLine(array[k]);
                        }
                    }
                    break;
                }

                else
                {
                    Console.WriteLine("Girdiğiniz Sayı Pozitif Değil");
                }

            }
        }
    }
}
