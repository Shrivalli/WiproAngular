using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSEg
{
    internal class Samsung : ICalculator
    {
        public int Add(int x, int y)
        {
            return x + y + 8;
        }

        public int Divide(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
