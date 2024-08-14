using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection; 
using System.Text;
using System.Threading.Tasks;

namespace ADONETEG
{
    class Sample
    {
        static void main(string[] args)
        {
            User user = new User();
            Type type = user.GetType();
            PropertyInfo prop = type.GetProperty("Name");
            prop.SetValue(user, "Bangalore", null);
            System.Console.WriteLine(user.Name);
            Console.ReadLine();
        }
    }
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

