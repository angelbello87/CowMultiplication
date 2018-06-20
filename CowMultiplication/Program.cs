using System;
namespace CowMultiplication
{
    class Program
    {
        static void Main()
        {
            string[] read = Console.ReadLine().Split();
            string a = read[0];
            string b = read[1];
            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    c += int.Parse(a[i].ToString()) * int.Parse(b[j].ToString());
                }
            }
            Console.WriteLine(c);
        }
    }
}
