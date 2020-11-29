using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // input array with strings
            string[] fruits = new string[] {"apple", "banana", "mango", "melon", "blackberries", "blueberries"};
            
            // placeholder arrays for storing letters and count
            string [] firstLetters = new string [fruits.Length];
            int [] counts = new int [fruits.Length];
            
            // intermediator variables
            string firstLetter;
            int uniqueLetters = 0;

            // loop through array
            for (int i = 0; i < fruits.Length; i++)
            {
                firstLetter = fruits[i].Substring(0, 1);
                
                // check if we have encountered the letter before, if so ++
                bool found = false;
                for (int j = 0; j < uniqueLetters; j++) {
                    if (firstLetters[j] == firstLetter) {
                        found = true;
                        counts[j]++;
                        break;
                    }
                }
                
                // if letter is not found in letter array, add new index and set count to 1
                if (!found) {
                    firstLetters[uniqueLetters] = firstLetter;
                    counts[uniqueLetters] = 1;
                    uniqueLetters++;
                }                
            }
            
            // print array of letters
            for (int i = 0; i < uniqueLetters; i++)
                Console.WriteLine($"{firstLetters[i]}: {counts[i]}");
        }
    }
}