using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSEg
{
    internal class CalciClient
    {
        public static void main()
        {
            ICalculator c=new Casio();
           // Casio abc = new Casio();
            
            int result=c.Add(4, 5);
            Console.WriteLine(result);

            Console.WriteLine(c.concat("Good","Morning"));

            c = new Samsung();
            Console.WriteLine(c.Add(4, 5));
            ISciCal s = new Casio();
            Console.WriteLine(s.Add(3, 4));

            Casio c1 = new Casio();
           // Console.WriteLine(c1.concat("wel", "come"));
            Console.WriteLine(c1.message("Vandhana"));
        }
    }
}
