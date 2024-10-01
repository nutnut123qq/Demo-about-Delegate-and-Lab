using System;

public delegate void SampleDelegate<T>(T a, T b); // Generic delegate

public class MathOperations
{
    public void Add<T>(T a, T b)
    {
        dynamic x = a, y = b;
        Console.WriteLine("Add Result: {0}", x + y);
    }

    public void Subtract<T>(T a, T b)
    {
        dynamic x = a, y = b;
        Console.WriteLine("Subtract Result: {0}", x - y);
    }

    public void Multiply<T>(T a, T b)
    {
        dynamic x = a, y = b;
        Console.WriteLine("Multiply Result: {0}", x * y);
    }

    public void Divide<T>(T a, T b)
    {
        dynamic x = a, y = b;
        if (y != 0)
        {
            Console.WriteLine("Divide Result: {0}", x / y);
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }

    public void Run()
    {
        Console.WriteLine("Delegate Example with Generics");

        // Yêu cầu người dùng nhập giá trị a và b
        Console.Write("Enter the first number (a): ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number (b): ");
        int b = int.Parse(Console.ReadLine());

        // Instantiate the delegate
        SampleDelegate<int> dlgt = Add;
        dlgt += Subtract;
        dlgt += Multiply;
        dlgt += Divide;

        // Invoke delegate for integer values
        Console.WriteLine("Operations with integers:");
        dlgt(a, b);
    }
}