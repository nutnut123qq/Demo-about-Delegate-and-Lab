using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi8prn
{
    public delegate int MyDelegate(int numOne, int numTwo);

    class Baitap1
    {
        public static void Run()
        {
            int n1, n2;

            Console.Write("Enter the first number (n1): ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number (n2): ");
            n2 = int.Parse(Console.ReadLine());

            int result;

            MyDelegate obj1 = new MyDelegate(Add);
            result = obj1(n1, n2);
            Console.WriteLine($"{n1} + {n2} = {result}");

            MyDelegate obj2 = Subtract;
            result = obj2.Invoke(n1, n2);
            Console.WriteLine($"{n1} - {n2} = {result}");
        }

        static int Add(int numOne, int numTwo) => numOne + numTwo;
        static int Subtract(int numOne, int numTwo) => numOne - numTwo;
    }
}

