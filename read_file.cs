using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler {
    class ReadFromFile {
        static void Main() {
            var random = new Random();
            string[] lines = System.IO.File.ReadAllLines(@"names.txt");
            
            int index = random.Next(0, lines.Length);
            Console.WriteLine(lines[index]);
        }
    }   
}