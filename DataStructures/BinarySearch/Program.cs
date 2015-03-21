using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
		static int[] CreateArray(int _num)
        {
            int[] array = new int[_num];
            Random random = new Random();

            for (int i = 0; i < _num; i++) {
                array[i] = random.Next(1, 150);
            }
            
            return array;
        }

		// TODO Continue work on this. Make it recursive. Possibly a quick sort instead of just meh.
		static int[] Sort(int[] _array)
        {
			int index = 0;
			int current = _array [index];
			int next = _array [index+1];

			for (int i = 0; i < _array.Length; i++) {
				if (current < next) {
					Console.WriteLine (current + " is less than " + next + " ... so swapping.");
					int temp = current;
					current = next;
					next = temp;
					index += 1;
					return Sort (_array);
				}
			}

			return _array;
        }

		static void BSearch(int[] _array, int _tValue)
        {

        }

        static void Main(string[] args)
        {
			Console.WriteLine ("How big should the array be: ");
			var numOfInts = Console.ReadLine ();
			int num = Convert.ToInt32 (numOfInts);
			int[] testArray = CreateArray(num);

			for (int i = 0; i < testArray.Length; i++) {
				Console.WriteLine("Old Pos " + i + ": " + testArray[i]);
			}

			int[] sortedArray = Sort (testArray);

			for (int i = 0; i < sortedArray.Length; i++) {
				Console.WriteLine("Pos " + i + ": " + sortedArray[i]);
            }

			// Query the user for input to search the array for.
			Console.WriteLine ("\nEnter a number to search for: \n");

			var input = Console.ReadLine ();
			if (input != null) {
				BSearch (sortedArray, Convert.ToInt32 (input));
			}

			// Add a check to see if user input is an int
        }
    }
}