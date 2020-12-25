using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoccerStats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Directory lets you traverse and manipulate directories
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var files = directory.GetFiles("*.txt");

            // Path combines two strings into a directory path => adds the \ into the string
            var fileName = Path.Combine(directory.FullName, "data.txt");
            var file = new FileInfo(fileName);

            // check if file exists, then sets the text if file does.
            if (file.Exists)
            {
                // after this block of code is finished, the dispose method of stream reader is called
                // dispose method will call close method to close the file for garbage collection
                using (var reader = new StreamReader(file.FullName))
                {
                    Console.SetIn(reader);
                    // The readline will read from text file and not prompt
                    Console.WriteLine(Console.ReadLine());
                }

            }
        }
    }
}
