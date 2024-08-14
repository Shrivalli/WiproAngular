using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcClientPrj
{
    internal class multicastdel
    {
        public delegate void PrintDel(string message);
        public static void main()
        {
            Console.WriteLine("Enter the message");
            string message = Console.ReadLine();
            // WriteToConsole(message);
            //WriteToFile(message);

            PrintDel d1 = new PrintDel(WriteToConsole);
            PrintDel d2 = new PrintDel(WriteToFile);
            PrintDel d3 = d1 + d2; //multicast delegate
            d3(message);
        }

        public static void WriteToConsole(string message)
        {
            Console.WriteLine(message);
        }

        public static  void WriteToFile(string message)
        {
            FileStream fs=new FileStream("message.txt",FileMode.Create, FileAccess.Write);  
            StreamWriter sw=new StreamWriter(fs);
            sw.WriteLine(message);
            sw.Flush();
            fs.Close();
        }
    }
}
