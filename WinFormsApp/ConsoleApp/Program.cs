using Calculater1;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2 , result;
            result = 0;
            string opt;
            Console.Write("Birinci sayıyı giriniz : ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Opreatör giriniz : ");
            opt= Convert.ToString(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz : ");
            s2 = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case "+": result = Class1.Add(s1, s2); break;
                case "-": result = Class1.Sub(s1, s2); break;
                case "/": result = Class1.Divide(s1, s2); break;
                case "x": result = Class1.Multiply(s1, s2); break;

            }
 


            Console.WriteLine("Sonuç = "+result);
        }
    }
}
