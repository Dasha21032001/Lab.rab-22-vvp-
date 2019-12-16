using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace з2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес файла: ");
            string adres = Console.ReadLine();
            Console.WriteLine("Введите N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите K: ");
            int K = Convert.ToInt32(Console.ReadLine());
            IEnumerable <string> s = Enumerable.Range(0, K).Select(c => "*");
            for (int i = 0; i < N; i++)
            {
                File.AppendAllText(adres, string.Join("", s));
                File.AppendAllText(adres, Environment.NewLine);
            }
        }
    }
}
