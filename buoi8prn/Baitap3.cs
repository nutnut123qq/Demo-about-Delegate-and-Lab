using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi8prn
{
    public delegate void MyDelegate3(string msg);

    class Baitap3
    {
        public static void Run()
        {
            Console.Write("Enter a message: ");
            string msg = Console.ReadLine();

            MyDelegate3 MyDele01 = MyClass.Print;
            MyDelegate3 MyDele02 = MyClass.Show;

            Console.WriteLine("***Combines MyDele01 + MyDele02***");
            MyDelegate3 MyDele = MyDele01 + MyDele02;
            MyDele(msg);

            Console.WriteLine("***Combines MyDele01 + MyDele02 + MyDele03***");
            MyDelegate3 MyDele03 = MyClass.Display;
            MyDele += MyDele03;
            MyDele(msg);

            Console.WriteLine("----------------------------");
            Console.WriteLine("***Remove MyDele02***");
            MyDele -= MyDele02;
            MyDele("Hello World!");
        }

        class MyClass
        {
            public static void Print(string message)
            {
                Console.WriteLine(message.ToUpper());
            }

            public static void Show(string message)
            {
                Console.WriteLine(message.ToLower());
            }

            public static void Display(string message)
            {
                Console.WriteLine($"Display: {message}");
            }
        }
    }
}
