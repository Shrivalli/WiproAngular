using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcClientPrj
{
    class PredicateEg
    {
        static void Main(string[] args)
        {
            Predicate<string> CheckIfApple = IsApple;
            bool result = IsApple("I Phone X");
            if (result==true)
                Console.WriteLine("It's an IPhone");
            else
                Console.WriteLine("Its not an IPhone");
        }

        private static bool IsApple(string modelName)
        {
            if (modelName == "I Phone X")
                return true;
            else
                return false;
        }
    }
}
