using System;
namespace FirstConsole
{
    class Program
    {
        //Entry point of execution
        public static void main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int result = first + second;
            if(result>10)
            {
                Console.WriteLine("Print result is greater than 10");
            }
            else
            {
                Console.WriteLine("Result is less than 10");
            }
            Console.WriteLine("The result is :" + result);
        }

    }
}
