using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcClientPrj
{
    internal class Delegateeg
    {
        //Delegate Declaration - single Cast Delegate
        public delegate int AddDel(int x, int y);

        //Delegate is a funciton pointer
        public static void main()
        {
            AddDel d1 = new AddDel(Add);
            int c = d1(4, 5);

            AddDel d2 = new AddDel(Mul);
            int product = d2(4, 5);
            Console.WriteLine("Product "+product);
            //int c = Add(4, 5);
            Console.WriteLine(c);
        }

        public static int Mul(int x, int y)
        {
            return x *(int) y;
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
