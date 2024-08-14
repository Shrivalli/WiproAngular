using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSEg
{
    //user defined exception
    internal class AgeNotValidException:ApplicationException
    {
        //Base class initialization
        public AgeNotValidException(string msg):base(msg) { }
    }

    class Voting
    {
        public void CheckAge(int age)
        {
            if(age>18)
            {
                Console.WriteLine("Thanks for voting!!");
            }
            else
            {
                //is used to raise an exception
                throw new AgeNotValidException("Sorry! you are not eligble to Vote!!!");
            }
        }
    }
}
