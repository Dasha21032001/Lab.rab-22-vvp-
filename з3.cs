using System;
using System.IO;
namespace з3
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = File.ReadAllText(@"C:\Users\USER\Desktop\z2.txt");
            StreamWriter s = new StreamWriter(@"C:\Users\USER\Desktop\z2.txt");
            string file2 = File.ReadAllText(@"C:\Users\USER\Desktop\z1.txt");
            s.Write(file2);
            s.Write(file1);
            s.Close(); 

        }
    }
}
