using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSEg
{
    internal class Casio : ICalculator,ISciCal
    {
        public string message(string name)
        {
            return "Hello "+name;
        }
         int ICalculator.Add(int x, int y)
        {
            return x + y;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        //public override string concat(string s1,string s2)
        //{
        //    return s1 + s2 + "abc";
        //}
         int ISciCal.Add(int x, int y)
        {
            return x + y + 5;
        }
    }
}
