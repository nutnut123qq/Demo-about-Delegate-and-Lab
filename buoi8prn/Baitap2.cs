using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi8prn
{
    public delegate void MyDelegate2(string msg);

    class Baitap2
    {
        public static void Run()
        {
            Console.Write("Enter a message: ");
            string msg = Console.ReadLine();

            MyDelegate2 printDelegate = new MyDelegate2(MyClass.Print);
            MyDelegate2 showDelegate = new MyDelegate2(MyClass.Show);

            InvokeDelegate(printDelegate, msg);
            InvokeDelegate(showDelegate, msg);
        }

        static void InvokeDelegate(MyDelegate2 dele, string msg)
        {
            dele(msg);
        }

        class MyClass
        {
            public static void Print(string message)
            {
                Console.WriteLine($"{message.ToUpper()}");
            }

            public static void Show(string message)
            {
                Console.WriteLine($"{message.ToLower()}");
            }
        }
    }
}
