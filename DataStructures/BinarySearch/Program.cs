using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void CreateArray()
        {
            int[] bsArray = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};

            foreach (var i in bsArray)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            CreateArray();

            var userInput = Console.ReadLine();
        }
    }
}
