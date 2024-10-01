using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi8prn
{
    class Baitap5
    {
        public static void Run()
        {
            Console.Write("Enter the first number (a): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number (b): ");
            int b = int.Parse(Console.ReadLine());

            Func<int, int, int> sumFunc = Sum;
            int s = sumFunc(a, b);

            string strResult = $"{a} + {b} = {s}";
            Console.WriteLine("***Invoke Sum method by Func delegate***");

            Action<string> action = Print;
            action(strResult);
        }

        static int Sum(int x, int y) => x + y;

        static void Print(string msg) => Console.WriteLine(msg.ToUpper());
    }
}
