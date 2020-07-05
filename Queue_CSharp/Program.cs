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
            m.Print();
            Console.WriteLine();
            Console.WriteLine(m);
            foreach (int i in m) Console.WriteLine(i);
            Queue<int> m2 = new Queue<int>(5);
            m2.Print();
            Console.ReadLine();
        }
    }
}
