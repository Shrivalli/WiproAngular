using System.Data.SqlClient;
using System.Data.Odbc;
using System.Reflection.PortableExecutable;
using System.Data;
namespace ADONETEG
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static void Main()
        {
            // InsertData();

            Disconselect();

        }

        private static void InsertData()
        {
            Getcon();
            Console.WriteLine("Enter Cid, Cname and fees ");
            int Cid = Convert.ToInt32(Console.ReadLine());
            string Cname = Console.ReadLine();
            float fees = float.Parse(Console.ReadLine());
            cmd = new SqlCommand("insert into courses values(@cid,@coursename,@fees)");
            cmd.Parameters.AddWithValue("@cid", Cid);
            cmd.Parameters.AddWithValue("@coursename", Cname);
            cmd.Parameters.AddWithValue("@fees", fees);
            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine(i + " Record(s) got inserted successfully");

        }

        //Disconnected Architecture - Data Adapter and dataset
        public static void Disconselect()
        {
            Getcon();
            cmd = new SqlCommand("select * from Courses;select * from student", con);
            SqlDataAdapter da=new SqlDataAdapter(cmd); //execution of query - da has records
            DataSet ds = new DataSet();
            da.Fill(ds); //Dataset is a front end database - collection of datatables
            DataTable dt = ds.Tables[0]; //point to course table
            DataTable dt1 = ds.Tables[1];//point to student table

            foreach(DataRow dr in dt.Rows)  //Datatable is collection of DataRows
            {
                foreach(var item in dr.ItemArray) //DataRow is a collections of DataColumns
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
            }


        }
        
        //connected architecture
        private static void SelectData()
        {
            Console.WriteLine("Displaying the Records");
            Getcon();
            cmd = new SqlCommand("select * from Courses", con);
            // cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
           
            for (int i = 0; i < dr.FieldCount; i++)
            {
                Console.Write(dr.GetName(i) + " "); // Get column name
                
            }

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();
            while (dr.Read())
            {
                // Add data rows
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    
                    Console.Write(dr[i]+" ");
                    
                }
                Console.WriteLine();
            }
            
        }

         private static void Getcon()
        {
            OdbcConnection con1 = new OdbcConnection("Server=;Database=");
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=Wiprosampledb;Integrated Security=true");
            con.Open();
        }
    }
}