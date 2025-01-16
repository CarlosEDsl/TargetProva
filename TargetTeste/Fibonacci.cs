using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetTeste
{
    internal class Fibonacci
    {
        public static bool IsFibonacci(int number)
        {
            if (number < 0) return false;

            int a = 0;
            int b = 1;

            if (number == a || number == b) return true;

            int next = a + b;

            while (next <= number)
            {
                if (next == number)
                {
                    return true;
                }
                a = b;
                b = next;
                next = a + b;
            }

            return false;
        }

    }
}
