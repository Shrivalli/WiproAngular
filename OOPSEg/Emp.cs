using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOPSEg
{
    public class Emp
    {
        public string Name { get; set; }
       public int Age { get; set; }

        //public Emp() { }
        public Emp(string name, int age) { Name = name; Age = age; }

        public static void Serialize(Emp emp, string filename)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(Emp));
            StreamWriter stream = new StreamWriter(filename);
            Console.WriteLine("Writing Employee Information");
            try
            {
                mySerializer.Serialize(stream, emp);
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Exception for Serialization data : " + ex.Message);
                throw;
            }
            finally
            {
                stream.Close();
                Console.WriteLine("successfully wrote Employee information");
            }
        }
        public static void Deserialize(string filename)
        {
            Emp mp = null;
            XmlSerializer mySerializer = new XmlSerializer(typeof(Emp));
            FileStream myFileStream = new FileStream(filename, FileMode.Open);
            Console.WriteLine("Reading Employee Information");
            try
            {
                mp = (Emp)mySerializer.Deserialize(myFileStream);
               // Thread.Sleep(500);
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Exception for Deserialize data : " + ex.Message);
                throw;
            }
            finally
            {
                myFileStream.Close();
            }
            if (mp != null)
            {
                Console.WriteLine("Employee Name: {0}", mp.Name);
                Console.WriteLine("Employee Id: {0}", mp.Age.ToString());
            }
            else
            {
                Console.WriteLine("Deserialize Employee null value");
            }
        }
    }
}