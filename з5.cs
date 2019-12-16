using System;
using System.IO;
namespace з5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\USER\Desktop\z3.txt";
            int k = 0, i, k1 = 0;
            using (StreamReader s = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = s.ReadLine()) != null)
                {
                    k = 0;
                    i = 0;
                    while (line[i] == ' ')
                    {
                        k++;
                        i++;
                        if (k > 5) break;
                    }
                    if (k == 5) k1++;
                }
            }
            Console.WriteLine(k1);
        }
    }
}

