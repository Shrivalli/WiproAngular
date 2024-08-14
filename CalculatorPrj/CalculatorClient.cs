using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPrj
{
    internal class CalculatorClient
    {
        public static void Main()
        {
            ICalculator c=new Calculator();
            Console.WriteLine(c.add(5, 6)) ;
        }
    }
}
