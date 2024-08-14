using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSEg
{
    internal class ExceptionEg
    {
        public static void main()
        {
            int a, b, c = 0;
            Console.WriteLine("Enter 2 numbers");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                int[] x = new int[2] { 5, 6 };
                Console.WriteLine(x[9]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter only numbers");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("second number cannot be zero");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Result :"+c);

        }
    }
}
