using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] toyArray = { "action figure", "doll", "Legos" };
            List<string> toyList = new List<string>() { "action figure", "stuffed animal", "Legos" };
            toyList.Add("Barbie");
            toyList.Add("remote control car");
            toyList.Add("yo-yo");

            foreach(string toy in toyList)
            {
                Console.WriteLine(toy);
            }

            //for (int i = 0; i <toyList.Count; i++) // does the same thing as the foreach loop, notice .Count instead of .Length!
            //{
            //    Console.WriteLine(toyList[i]);
            //}

            // The properties and methods we will use the most are 
            // .Count
            // .Insert()
            // .Add()
            // .Remove()

            Console.WriteLine(toyList.Count);
            toyList.Remove("Barbie");
            Console.WriteLine(toyList.Count);

            // Insert allows us to put a new element in the list and specify which index we want for that element
            toyList.Insert(0, "kite");
            toyList.Insert(2, "baby doll");
            toyList.Insert(1, "plastic dinosaur");

            foreach (string toy in toyList)
            {
                Console.WriteLine(toy);
            }

            // Another method that we will often use is .Contains()
            // It returns a boolean value

            if (toyList.Contains("plastic dinosaur"))
            {
                Console.WriteLine("Daniel would never the buy the dino.");
            }
            else
            {
                Console.WriteLine("Daniel might buy any of these toys.");
            }

       
            
            List<string> employeeNames = new List<string>(); // list size can change so no need to assign it a size.
        }
    }
}
