using System;

namespace PatikaMetotOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "777";


           bool result= int.TryParse(num, out int outNum);
            if (result)
            {
                Console.WriteLine("Successful");
                Console.WriteLine(outNum);
            }
            else
            {

                Console.WriteLine("Unsuccessful");
            }
            Metotlar instance = new Metotlar();
            instance.Addition(2, 3, out int additionResult);
            Console.WriteLine(additionResult);
            //Metot Overloading
            int number = 8888 ;
            instance.Print(number);
            instance.Print("Büşra Yeşilalioğlu");
        }
    }
    class Metotlar
    {
        public void  Addition(int a , int b, out int addition)
        {
            addition = a + b;
        }
        public void Print(string str)
        {
            Console.WriteLine(str);
        }

        public void Print(int str)
        {
            Console.WriteLine(str);
        }

        public void Print(string str1,string str2)
        {
            Console.WriteLine(str1,str2);
        }
    }
}

