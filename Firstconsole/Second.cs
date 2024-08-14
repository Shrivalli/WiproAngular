using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstconsole
{
    internal class Second
    {
        public static void main()
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your DOB");
            DateTime dob=Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter salary");
            float salary = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the result");
            bool result=Convert.ToBoolean(Console.ReadLine());


            Console.WriteLine("Your Details are");
            Console.WriteLine("Your name is "+name);
            Console.WriteLine("Your age is {0} and dob is {1}",age,dob.ToShortDateString());
            Console.WriteLine($"your result is {result}");
            Console.WriteLine("Your Salary is {0}",salary);
        }
    }
}
