using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Testlib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Test
{
   
        class Sample
        { 

        public static void main()
        {
            int i = 10;
            Type t = i.GetType();
            Console.WriteLine("Data type of i is :"+t);
            // dynamically load assembly from file Test.dll
            Assembly testAssembly = Assembly.LoadFile(@"E:\Wipro\dotnet with Angular Batch\Testlib\bin\Debug\net8.0\TestLib.dll");


            // get type of class Calculator from just loaded assembly
            Type calcType = testAssembly.GetType("Testlib.Calculator");

            // create instance of class Calculator
            object calcInstance = Activator.CreateInstance(calcType);
                       
            // get info about property: public double Number
            PropertyInfo numberPropertyInfo = calcType.GetProperty("Number");
            #region
            // get value of property: public double Number
            //double value = (double)numberPropertyInfo.GetValue(calcInstance, null);
            // set value of property: public double Number
            //numberPropertyInfo.SetValue(calcInstance, 10.0, null);
            #endregion
            var properties = calcType.GetProperties();

            Console.WriteLine("Displaying all Properties of Class Calculator");
            foreach (var item in properties)
            {
                Console.WriteLine(item.Name);
            }
           var methods = calcType.GetMethods();

            Console.WriteLine("Displaying all methods of Class Calculator");
            foreach (var item in methods)
            {
                Console.WriteLine(item.Name);
            }
        }

    }
}
