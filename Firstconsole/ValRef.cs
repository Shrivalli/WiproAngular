using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstconsole
{
    class Student
    {
        public int MathsMarks;
        public int ScienceMarks;
    }
    internal class ValRef
    {
        public static void Main()
        {
            Student Ram = new Student();
            Ram.MathsMarks = 40;
            Ram.ScienceMarks = 50;
            Student Sita = Ram;
            Console.WriteLine("Ram's Mathsmarks: "+Ram.MathsMarks);
            Console.WriteLine("Ram's ScienceMarks: " + Ram.ScienceMarks);
            Console.WriteLine("Sita's Mathsmarks: " + Sita.MathsMarks);
            Console.WriteLine("Sita's ScienceMarks: " + Sita.ScienceMarks);
            Ram.MathsMarks = 80;
            Ram.ScienceMarks = 90;
            Console.WriteLine("Ram's Mathsmarks: " + Ram.MathsMarks);
            Console.WriteLine("Ram's ScienceMarks: " + Ram.ScienceMarks);
            Console.WriteLine("Sita's Mathsmarks: " + Sita.MathsMarks);
            Console.WriteLine("Sita's ScienceMarks: " + Sita.ScienceMarks);

        }
    }
}
