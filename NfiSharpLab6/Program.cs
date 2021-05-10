using System;

namespace NfiSharpLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ett tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mata in ett till tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(tal1+tal2);
        }
    }
}
