using System;

namespace InterfaceOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********INTERFACE***************");
            ModelS modelS = new ModelS();
            Console.WriteLine(modelS.HangiMarka().ToString());
            Console.WriteLine(modelS.RenkNe().ToString());
            Console.WriteLine(modelS.KacTekerlek().ToString());


            Console.WriteLine("***********ABSTRACT***************");
            NewModelS newModelS = new NewModelS();
            Console.WriteLine(newModelS.HangiMarka().ToString());
            Console.WriteLine(newModelS.RenkNe().ToString());
            Console.WriteLine(newModelS.KacTekerlek().ToString());

        }
    }
}
