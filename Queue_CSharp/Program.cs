using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 15, 20 };
            Queue<int> m = new Queue<int>(arr);
            Queue<int> temp = m.FindAll(x => x % 2 == 0);
            temp.Print();
            Console.WriteLine();
            int s = m.Find(x => x % 3 == 0);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
