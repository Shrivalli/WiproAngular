using Calclib;
namespace CalcClientPrj
{
    class Program
    {
        public static void main(string[] args)
        {
            
            Console.WriteLine("Enter 2 numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            ICalculator obj = new Calculator();
            Console.WriteLine(obj.add(a, b));
        }
    }
} 