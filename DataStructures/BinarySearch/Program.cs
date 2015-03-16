using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static int[] CreateArray()
        {
            int[] bsArray = new int[16];
            Random random = new Random();

            for (int i = 0; i <= 15; i++)
            {
                bsArray[i] = random.Next(1, 150);
            }
            
            return bsArray;
        }

        static void SortArray()
        {

        }

        static void SearchArray()
        {

        }

        static void Main(string[] args)
        {
            int[] testArray = CreateArray();

            foreach (var i in testArray)
            {
                Console.WriteLine(i);
            }

            var userInput = Console.ReadLine();
        }
    }
}
