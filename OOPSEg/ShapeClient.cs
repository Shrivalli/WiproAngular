using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSEg
{
    internal class ShapeClient
    {
        public static void main()
        {
          //  Shape s1 = new Shape();--error
          //s1.calculateArea();
            Shape s = new Circle();//runtime polymorphism
           //new - base , override - derived
            
           // Circle c = new Circle();
            s.Accept();
            s.CalculateArea();
            s.Display();

            //Rectangle s = new Rectangle();
            //s.Accept(); //Accept color
            //s.GetRectDetails(); //Len and Bre

            //s.CalculateArea();//print statement
            //s.CalculateRectArea(); //CalculateArea of rectangle

            //s.ShowRectDetails(); //Show the len and bre
            //s.Display(); //Display Area and color

        }
    }
}
