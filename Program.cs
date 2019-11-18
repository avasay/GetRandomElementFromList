using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSList2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize our list
            List<string> mylist = new List<string>(new string[] { "biology-1", "biology-2", "biology-3" });

            Random R = new Random();

            // get random number from 0 to 2. 
            int someRandomNumber = R.Next(0, mylist.Count());

            Console.WriteLine("Hello {0}", mylist.ElementAt(someRandomNumber));
            Console.ReadKey();

        }
    }
}
