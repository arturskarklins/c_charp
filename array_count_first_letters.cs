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
            string[] fruits = new string[] { "apple", "banana", "mango", "melon", "blackberries", "blueberries"};
            
            string [] firstLetters = new string [fruits.Length];
            int [] counts = new int [fruits.Length];
            string firstLetter;
            int uniqueLetters = 0;

            for (int i = 0; i < fruits.Length; i++)
            {
                firstLetter = fruits[i].Substring(0, 1);
                
                bool found = false;
                for (int j = 0; j < fruits.Length; j++) {
                    if (firstLetters[j] == firstLetter) {
                        found = true;
                        counts[j]++;
                        break;
                    }
                }
                
                if (!found) {
                    firstLetters[uniqueLetters] = firstLetter;
                    counts[uniqueLetters] = 1;
                    uniqueLetters++;
                }                
            }
            
            for (int i = 0; i < firstLetters.Length; i++){
                if (counts[i] != 0)
                    Console.WriteLine($"{firstLetters[i]}: {counts[i]}");
            }
        }
    }
}