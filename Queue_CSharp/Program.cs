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
            Queue m = new Queue(arr);
            m.Print();
            Console.ReadLine();
        }
    }
}
