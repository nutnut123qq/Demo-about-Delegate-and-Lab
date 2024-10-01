using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi8prn
{

    public delegate void MyDele4(int value);

    class Baitap4
    {
        public static void Run()
        {
            MyDele4 printValue = delegate (int val)
            {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            printValue += delegate
            {
                Console.WriteLine("This is Anonymous Method.");
            };

            printValue(100);

            Console.ReadLine();
        }
    }

}
