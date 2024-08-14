using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSEg
{
    internal class StudentClient
    {
        public static void main()
        {
            Student s1=new Student(); //Instantiation - creating an instance
            //s1.Accept();
            s1.Display();
            Student s2 = new Student(102, "Vandhana", 55,"WiproSis");
           // s2.Accept();
            s2.Display();
            Student s3 = new Student();
            
            // s3.sid = -900; //concept of encapsulation

            s3.Sid = -900;
            s3.Sname = "Krish";
            s3.Age = 90;
           // s3.Cname = "CTS"; //read only properties 
            s3.Display();
        }
    }
}
