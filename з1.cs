using System;
using System.IO;
namespace з1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fail = @"C:\Users\USER\Desktop\z1.txt";
            string text = File.ReadAllText(fail);
            text= text.Substring(text.IndexOf(' ') + 1);
            File.WriteAllText(fail, text);

            StreamReader x = new StreamReader(@"C:\Users\USER\Desktop\z1.txt");
            Console.Write(x.ReadToEnd());
            x.Close();
        }
    }
}

