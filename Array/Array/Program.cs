using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[] { "Item1", "Item2", "Item3",
                "Item4", "Item5", "Item6", "Item7", "Item8", "Item9", "Item10"};

            Console.WriteLine("Item at index 2 is : " + myArray[2]);
            Console.WriteLine();
            Console.WriteLine("This is the contens of array : ");

            foreach (string value in myArray)
            {
                Console.WriteLine(value);
            }
        }
    }

}

