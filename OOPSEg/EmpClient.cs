using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPSEg
{
    internal class EmpClient
    {
        public static void Main()
        {
            Emp emp = new Emp("Sruthi", 17);
            Emp.Serialize(emp, "abc.txt");
            Emp.Deserialize("abc.txt");
            
        }
    }
}
