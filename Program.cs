using System;

namespace patika.ortalamaHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number => ");
            int number = 0;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine((Fibonacci.Calculate(number)).ToString("N2"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
