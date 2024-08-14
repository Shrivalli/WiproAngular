using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSEg
{
    internal class FileEg
    {
        public static void main()
        {
            WriteToFile();
            ReadFromFile();
        }
        private static void ReadFromFile()
        {
            FileStream fs=new FileStream("WiproFile.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr=new StreamReader(fs);
            string? line; //nullable variable
            while((line=sr.ReadLine())!=null)
                {
                Console.WriteLine(line);
                }
        }
        private static void WriteToFile()
        {
            FileStream fs = new FileStream("WiproFile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter the text to be written in the file");
            string username = Console.ReadLine();
            sw.WriteLine("Welcome " + username + DateTime.Now);
            sw.Flush();
            fs.Close();
        }
    }
}
