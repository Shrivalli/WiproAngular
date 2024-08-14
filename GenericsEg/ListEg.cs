using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEg
{
    internal class ListEg
    {
        public static void main()
        {
            List<int> l = new List<int>(); //TypeSpecific
            l.Add(78);
            l.Add(34);
            l.Add(90);

            l.Sort();
            
            foreach(int item in l)
            {
                Console.WriteLine(item);
            }

            List<string> fruits=new List<string>();
            fruits.Add("Apple");
            fruits.Add("Kiwi");

            foreach (string item in fruits)
            {
                Console.WriteLine(item);
            }

            }
    }
}
