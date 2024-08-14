using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcClientPrj
{
    internal class FunctionDel
    {
        private static int result;
        public static void main()
        {

            //Func<int, int, int> Addition = AddNumbers;
            //Console.WriteLine($"Addition = {result}");
            // Action<int, int> Addition = AddNumbers;
            //Addition(10, 20);

            //Func<int, int, int> Addition = delegate (int param1, int param2)
            //{
            //    return param1 + param2;
            //};

            //Action<int, int> Addition = delegate (int param1, int param2)

            //{
            //    result = param1 + param2;
            //};
            Action<int, int> Addition = (param1, param2) => result = param1 + param2; ;
            Addition(10, 20);
            Console.WriteLine($"Addition = {result}");
            
        }

        //private static void AddNumbers(int param1, int param2)
        //{
        //    Console.WriteLine(param1 + param2);
        //}
    }
}
    

