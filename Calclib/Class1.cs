namespace Calclib
{

    //Purpose of class libraries are for reusability
    //No main method and it cannot be executed. Only can be build.
    public interface ICalculator
    {
        int add(int x, int y);
    }
    public class Calculator : ICalculator
    {
        public int add(int x, int y)
        {
            return x + y;
        }
    }
}
