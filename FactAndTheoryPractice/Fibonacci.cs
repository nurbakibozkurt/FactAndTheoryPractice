using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactAndTheoryPractice
{
    public class FibonacciCalculator
    {
        public int Calculate(int n)
        {
            if (n < 2)
                return n;
            else
                return Calculate(n - 1) + Calculate(n - 2);
        }
    }

}
