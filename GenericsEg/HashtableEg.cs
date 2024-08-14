using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GenericsEg
{
    internal class HashtableEg
    {
        public static void Main()
        {
            //Hashtable ht=new Hashtable();//non generic collection
            Dictionary<int,string> ht = new Dictionary<int,string>(); //generic collection
            ht.Add(101, "Apple");
            ht.Add(102, "Banana");
            ht.Add(103, "Kiwi");
            ht.Add(104, "Chikku");
            ht.Add(105, null);
            Console.WriteLine("Displaying Keys");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Displaying Values");
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Display Keys and Values");
            foreach (KeyValuePair<int,string> item in ht)
            {
                Console.WriteLine(item.Key+"  "+item.Value);
            }
            Console.WriteLine("Enter the search item");
            int search=Convert.ToInt32(Console.ReadLine());
            if (ht.ContainsKey(search))
            {
                Console.WriteLine(ht[search]);
            }
            else
            {
                Console.WriteLine("Sorry! item not found");
            }
        }
    }
}
