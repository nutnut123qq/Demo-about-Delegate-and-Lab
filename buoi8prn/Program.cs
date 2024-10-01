using buoi8prn;

namespace buoi8prn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = -1; 
            while (choice != 0) 
            {
                Console.WriteLine("Choose which exercise to run (1-6), or press 0 to exit:");
                Console.WriteLine("1 - Baitap1 (Add and Subtract using Delegate)");
                Console.WriteLine("2 - Baitap2 (Delegate Parameter for Print and Show)");
                Console.WriteLine("3 - Baitap3 (Multicast Delegate)");
                Console.WriteLine("4 - Baitap4 (Anonymous Method Delegate)");
                Console.WriteLine("5 - Baitap5 (Func and Action Delegates)");
                Console.WriteLine("6 - MathOperations (Generic Delegate Example)");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Baitap1.Run();
                            break;
                        case 2:
                            Baitap2.Run();
                            break;
                        case 3:
                            Baitap3.Run();
                            break;
                        case 4:
                            Baitap4.Run();
                            break;
                        case 5:
                            Baitap5.Run();
                            break;
                        case 6:
                            MathOperations mathOperations = new MathOperations();
                            mathOperations.Run();
                            break;
                        case 0:
                            Console.WriteLine("Exiting the program...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please choose a number between 1 and 6, or 0 to exit.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                Console.WriteLine(); 
            }
        }


    }
}
