using System;
using System.Text.RegularExpressions;
using System.IO;

namespace з4
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = File.ReadAllText(@"C:\Users\USER\Desktop\z1.txt");
            var novstr = new Regex(@"\s+").Replace(file1, " ");
            Console.WriteLine(novstr);
            Console.WriteLine();
        }
    }
}
