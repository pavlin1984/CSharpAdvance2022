using System;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("input.txt"))
            {
                using (StreamWriter sw = new StreamWriter("output.txt"))
                {

                    int rowNumber = 0;
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        if (rowNumber % 2 == 1)
                        {
                            sw.WriteLine(line);
                        }
                        rowNumber++;
                    }
                }
            }
        }
    }
}
