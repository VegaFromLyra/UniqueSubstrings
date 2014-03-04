using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Find all unique substrings within a string
// Follow up: sort the result
// Time - O(n ^ 2)
namespace UniqueSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "ratatat";

            var result = FindUniqueSubStrings(input);

            Console.WriteLine("The unique substrings in sorted order are");

            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }

        static List<string> FindUniqueSubStrings(string input)
        {
            HashSet<string> map = new HashSet<string>();

            return FindUniqueSubStrings(input, map);
        }

        static List<string> FindUniqueSubStrings(string input, HashSet<string> map)
        {
           for(int i = 0; i < input.Length; i++)
           {
               map.Add(input[i].ToString());

               for(int j = i + 1; j < input.Length; j++)
               {
                   String subString = input[i] + input.Substring(i + 1, j - i);

                   map.Add(subString);
               }
           }

           var result = map.ToList();

           result.Sort();

           return result;
        }

    }
}
