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

       
            
            List<string> employeeNames = new List<string>(); // list size can change so no need to assign it a size.
        }
    }
}
