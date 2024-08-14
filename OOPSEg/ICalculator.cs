using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSEg
{
    internal interface ICalculator
    {
        //Method declarations
        int Add(int x, int y);
        int Subtract(int x, int y);
        int Multiply(int x, int y);
        int Divide(int x, int y);

        //non abstract methods
        string concat(string a, string b)
        {
            return a + b;
        }

    }

    interface ISciCal
    {
        int Add(int x, int y);
    }
}
