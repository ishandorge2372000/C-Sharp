using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            // Build a query expression to find the items in the array
            // that have an embedded space.

            IEnumerable<string> res = from g in currentVideoGames where g.Contains("o") orderby g select g;
            foreach (string s in res)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
            /*
             output :
             Fallout 3
             Morrowind
             System Shock 2
             */
        }
    }
}
