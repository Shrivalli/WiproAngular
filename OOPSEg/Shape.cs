using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSEg
{
    internal abstract class Shape
    {
        //Auto implemented Properties
        public string Color { get; set; }
        public float Area { get; set; }

        public virtual void Accept()
        {
            Console.WriteLine("Enter Color");
            Color = Console.ReadLine();
        }

        //Abstract methods are methods without definition
        public abstract void CalculateArea();
        //{
        //    //Console.WriteLine("Calculate Area method of Shape class");
        //}

        public virtual void Display()
        {
            Console.WriteLine("Color: "+Color);
            Console.WriteLine("Area: " + Area);
        }
    }

    class  Rectangle :Shape
    {
        public int Length { get; set; }
        public int Breadth { get; set; }

        public void GetRectDetails()
        {
            Console.WriteLine("Enter Length and Breadth");
            Length = Convert.ToInt32(Console.ReadLine());
            Breadth = Convert.ToInt32(Console.ReadLine());
        }

        public override void CalculateArea()
        {
            Area = Length* Breadth;
        }

    public void ShowRectDetails()
        {
            Console.WriteLine("Length: "+Length+" Breadth: "+Breadth);
            
        }
    }

    class Circle : Shape
    {
        public int radius { get; set; }

        //method overriding - A method of the base class is redefined in the
        //derived class with the same name
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter Radius");
            radius = Convert.ToInt32(Console.ReadLine());
        }

        //public new void Accept()
        //{
        //   // base.Accept();
        //    Console.WriteLine("New method of Derived class");
        //}

        public  override void CalculateArea()
        {
            //base.CalculateArea();
            Area =float.Parse((3.14 * radius * radius).ToString());
        }

        public override void Display()
        {
            Console.WriteLine("Radius: "+radius);
            //base.Display();
        }
    }
}
