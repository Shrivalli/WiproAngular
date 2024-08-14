namespace Testlib
{
    //Reflection - metadata of an assembly - exe, dll
    public class Calculator
    {
        public Calculator() { } //constructor

        private double _number; //member variable
        public double Number { get; set; } //property
        public void Clear() { } //Method
        private void DoClear() { }//Private method
        public double Add(double number) { return number + 2; } //Method
        public static double Pi { get; set; } //Property
        public static double GetPi() { return 3.14; } //Method
    }
}
