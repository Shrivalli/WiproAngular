using System.Security.Cryptography.X509Certificates;

namespace CalculatorPrj
{
    public interface ICalculator
    {
        int add(int x, int y);
        int subtract(int x, int y);
        int multiply(int x, int y);
        int divide(int x, int y);

        int inc(int x);

        string message(string name);

        bool checkAge(int age);
        
    }

    public class Calculator : ICalculator
    {

        public int inc(int x)
        {
            return x + 1;
        }
        public int add(int x, int y)
        {
            int z=inc(x);
            return z + y;
        }



        public int divide(int x, int y)
        {
            return x / y;
        }

        public string message(string name)
        {
            return "Hello " + name;
        }

        public int multiply(int x, int y)
        {
            return x * y;
        }

        public int subtract(int x, int y)
        {
            return x - y;
        }

        public bool checkAge(int age)
        {
            if (age > 18)
                return true;
            else
                return false;
        }
    }
}
