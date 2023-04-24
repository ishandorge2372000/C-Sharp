//The below class has been refered in multiple programs
 public class Car
    {
        public string PetName { get; set; } = "";
        public string Color { get; set; } = "";
        public int Speed { get; set; }
        public string Make { get; set; } = "";
    }
-----------------------------------------------------------------------------
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
        }
    }
}
/*
     output :
     Fallout 3
     Morrowind
     System Shock 2
*/
//The same code can be written in another way as--------------------------------------------------------------------------------------------------------------
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

            IEnumerable<string> res = currentVideoGames.Where(g => g.Contains(" ")).OrderBy(g => g).Select(g => g);

            foreach (string s in res)
            {
                Console.WriteLine("VideoGame : {0}", s);
            }
            Console.ReadKey();            
        }
    }
}
/*
             output :
             VideoGame : Fallout 3
             VideoGame : System Shock 2
             VideoGame : Uncharted 2
*/
//The same code can be written without using Linq as----------------------------------------------------------------------------------------------------------------------------
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

            //if we write the same code without Linq

            string[] gamesWithSpaces = new string[5];
            int j = 0;

            for(int i=0 ; i < currentVideoGames.Length ; i++)
            {
                if (currentVideoGames[i].Contains(" "))
                {
                    gamesWithSpaces[j++] = currentVideoGames[i];
                }
            }

            foreach(string game in gamesWithSpaces)
            {
                Console.WriteLine(game);
            }
            
            Console.ReadKey();
            
        }
    }
}
/*
Uncharted 2
Fallout 3
System Shock 2
 */
//-------------------------------------------------------------------------------------------------------------
public class Program
    {
        static void Main(string[] args)
        {
            var myCars = new List<Car>()
            {
                new Car() { PetName = "Daisy", Color = "Silver", Speed = 100, Make = "BMW"},
                new Car(){ PetName = "Henry", Color = "Tan", Speed = 90, Make = "BMW"},
                new Car(){ PetName = "Mary", Color = "Black", Speed = 110, Make = "VW"} 
            };

            myCars.Add(new Car() { PetName = "Clunker", Color = "Rust", Speed = 55, Make = "VW" });

            myCars.Add(new Car() { PetName = "Melvin", Color = "White", Speed = 99, Make = "Ford" });

            GetFastCars(myCars);
            Console.ReadKey();
        }

        static void GetFastCars(List<Car> myCars)
        {
            var fastCars = from cars in myCars 
                           where cars.Speed > 95 
                           select cars;

            Console.WriteLine("Cars with Fast Speed :");
            foreach(var fastCar in fastCars)
            {
                Console.WriteLine(fastCar.PetName);
            }
        }
    }
}

/*
 Cars with Fast Speed :
Daisy
Mary
Melvin
 */
------------------------------------------------------------------------------
//Union :
 public class Program
    {
        static void DisplayUnion()
        {
            List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };
            // Get the union of these containers.
            var carUnion = (from c in myCars select c).Union(from c2 in yourCars select c2);
            Console.WriteLine("Here is everything:");
            foreach (string s in carUnion)
                Console.WriteLine(s); // Prints all common members.
            Console.ReadKey();
        }
    }
-----------------------------------------------------------------------------------
