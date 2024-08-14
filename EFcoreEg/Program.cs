using EFcoreEg.Models;

namespace EFcoreEg
{
    //Entity frameworkcore - ORM - object Relation Mapping 
    //object - instance of a class
    //Relation - back end table of a db
    //map a table as a class or a class as a table

    //class Course //entity class - collection of entity class - context(front end db)
    //{
    //    public int cid { get; set; }
    //    public string cname { get; set; }
    //    public float fees { get; set; }
    //}

    //two approaches - 1. DB first approach 2. Code first approach
    //3 nuget packages to be installed - EFcore, EFCore SQL, EFCore Tools
    class Program
    {
      public static  WiproSampleDbContext context = new WiproSampleDbContext();
        public static void Main()
        {
            Console.WriteLine("Enter Course id ");
            int courseid = Convert.ToInt32(Console.ReadLine());
            DeleteCourse(courseid);
            //AddCourse();
            //FindACourseById(courseid);
            //GetAllCourses();
        }
        private static void AddCourse()
        {
            Console.WriteLine("Enter Cid, Cname and Fees");
            Course c = new Course();
            c.Cid=Convert.ToInt32(Console.ReadLine());
            c.Cname = Console.ReadLine();
            c.Fees = float.Parse(Console.ReadLine());
            context.Courses.Add(c);//add the record to the context
            context.SaveChanges();//save it to the db permenantly

        }

        private static void GetAllCourses()
        {
            foreach (var item in context.Courses)
            {
                Console.WriteLine(item.Cid + " " + item.Cname + " " + item.Fees);
            }
        }

        private static void FindACourseById(int courseid)
        {
            
            Course c = context.Courses.Where(x => x.Cid == courseid).SingleOrDefault();
            if (c != null)
            {
                Console.WriteLine(c.Cid + " " + c.Cname + " " + c.Fees);
            }
            else
            {
                Console.WriteLine("Sorry! record not found");

            }


        }

        private static void UpdateCourse(int id,Course c)
        {
            //get the id -> find the record - findcoursebyid()
            //remove the old record from context.courses
            //add the Course object to the context.courses  - savechanges

        }

        private static void DeleteCourse(int id)
        {
            Course c = context.Courses.Where(x => x.Cid == id).SingleOrDefault();
            context.Courses.Remove(c);
            context.SaveChanges();

        }
    }
}