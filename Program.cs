// See https://aka.ms/new-console-template for more information

using System;

namespace switch_case
{
    class Program
    {
        private const int V1 = 1;
        private const int V = V1;

        static void Main(string[]args, int v)
        {
            int month= DateTime.Now.Month;
            //expression
            switch (month)
            {
                case 1;
                Console.WriteLine("OCAK AYINDAYSAN");
                break;
                case 2;
                Console.WriteLine("ŞUBAT AYINDAYSAN");
                break;
                case 3;
                Console.WriteLine("MART AYINDAYSAN");
                break;
                default;
                Console.WriteLine("yanlış veri");
                break;


            }
        }
    }
}