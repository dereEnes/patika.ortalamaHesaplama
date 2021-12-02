using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika.ortalamaHesaplama
{
    class Fibonacci
    {
        public static double Calculate(int number)
        {
            int[] arrayOfFibo = new int[number];
            arrayOfFibo[0] = 0;
            arrayOfFibo[1] = 1;
            int sum = 1;
            for (int i = 2; i< number; i++)
            {
                arrayOfFibo[i] = arrayOfFibo[i - 1] + arrayOfFibo[i - 2];
                sum += arrayOfFibo[i];
            }
            double a =  (double)sum / (double)number;
            return a;
        }
    }
}
