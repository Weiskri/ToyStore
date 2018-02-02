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
            //List<string> toyList = new List<string>() { "action figure", "stuffed animal", "Legos" };
            //toyList.Add("Barbie");
            //toyList.Add("remote control car");
            //toyList.Add("yo-yo");

            //foreach(string toy in toyList)
            //{
            //    Console.WriteLine(toy);
            //}

            ////for (int i = 0; i <toyList.Count; i++) // does the same thing as the foreach loop, notice .Count instead of .Length!
            ////{
            ////    Console.WriteLine(toyList[i]);
            ////}

            //// The properties and methods we will use the most are 
            //// .Count
            //// .Insert()
            //// .Add()
            //// .Remove()

            //Console.WriteLine(toyList.Count);
            //toyList.Remove("Barbie");
            //Console.WriteLine(toyList.Count);

            //// Insert allows us to put a new element in the list and specify which index we want for that element
            //toyList.Insert(0, "kite");
            //toyList.Insert(2, "baby doll");
            //toyList.Insert(1, "plastic dinosaur");

            //foreach (string toy in toyList)
            //{
            //    Console.WriteLine(toy);
            //}

            //// Another method that we will often use is .Contains()
            //// It returns a boolean value

            //if (toyList.Contains("plastic dinosaur"))
            //{
            //    Console.WriteLine("Daniel would never the buy the dino.");
            //}
            //else
            //{
            //    Console.WriteLine("Daniel might buy any of these toys.");
            //}

            //List<bool> shelfStatus = new List<bool>() { true, false, true, true, false };
            //for (int i = 0; i<shelfStatus.Count; i++)
            //{
            //    if (shelfStatus[i] == true)
            //    {
            //        Console.WriteLine("There are toys on this shelf");
            //    }
            //    else if (shelfStatus[i] == false)
            //    {
            //        Console.WriteLine("This shelf is empty.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You broke the code!");
            //    }
            //}

            // Create a list, add five stuffed animals to the list.
            // Print each stuffed animal in the list.

            List<string> stuffedAnimalList = new List<string>() { "giraffe", "rabbit", "whale", "cat", "lion" };
            foreach (string stuffedAnimal in stuffedAnimalList)
            {
                Console.WriteLine(stuffedAnimal);
            }

            // practice question: create a list of numbers: 1, 23, 9, 77, 922, 6, 32, 63, 14, 5
            // Determine whether each of the following is in the list: 23, 77, 15
            // Remove the following elements: 27, 922, 32, 6
            // Then, determine whether these are elements in the list: 23, 77, 15

            List<int> numberList = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            if (numberList.Contains(23))
            {
                Console.WriteLine("23 is in the list.");
            }
            if (numberList.Contains(77))
            {
                Console.WriteLine("77 is in the list.");
            }
            if (numberList.Contains(15))
            {
                Console.WriteLine("15 is in the list.");
            }
            numberList.Remove(27);
            numberList.Remove(922);
            numberList.Remove(32);
            numberList.Remove(6);

            if (numberList.Contains(23))
            {
                Console.WriteLine("23 is in the list.");
            }
            if (numberList.Contains(77))
            {
                Console.WriteLine("77 is in the list.");
            }
            if (numberList.Contains(15))
            {
                Console.WriteLine("15 is in the list.");
            }


            /*List<string> employeeNames = new List<string>();*/ // list size can change so no need to assign it a size.
        }
    }
}
