 namespace OOPSEg
{
    class Student
    {
        //Member variables
        int sid;
        //string sname;
        //int age;


        //Properties
        public string Sname { get; set; } //Auto implemented Properties
        public int Age { get; set; }
        public string Cname { get; } //read only property - they can be assigned
        //values inside the constructors and not from main method.
        public int Sid
        {
            get
            {
                return sid;
            }
            set
            {
                if (value > 0)
                {
                    sid = value;
                }
                else
                {
                    sid = 0;
                }
            }
        }


        //Constructor
        public Student()
        {
            Sid = 100;
            Sname = "Ram";
            Age = 30;
            Cname = "Wipro";
        }

        //Overloaded constructor
        public Student(int sid, string stname, int sage,string cname)
        {
            this.Sid = sid;
            Sname = stname;
            Age = sage;
            Cname = cname;
        }

        public Student(int stid)
        {
            Sid = stid;
        }

        //Member functions
        //AccessSpecifier returntype methodname
        public void Accept()
        {
            Console.WriteLine("Enter Sid, Sname and Age");
            Sid = Convert.ToInt32(Console.ReadLine());
            Sname = Console.ReadLine();
            Age=  Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Your Details are:");
            Console.WriteLine("SID: "+Sid+" Name: "+Sname+" Age: "+Age+" Cname: "+Cname);
        }
    }
}