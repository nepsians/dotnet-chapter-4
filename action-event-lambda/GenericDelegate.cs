using System;

namespace Chapter4 {
    public class Program
    {
        public delegate T Operation<T>(T a, T b);

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static string Concatenate(string a, string b)
        {
            return a + b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static void Main()
        {
            // Using the delegate with integers
            Operation<int> intOperation = Add;
            int intResult = intOperation(5, 10);
            Console.WriteLine("Integer Addition: " + intResult); // Output: 15

            // Using the delegate with strings
            Operation<string> stringOperation = Concatenate;
            string stringResult = stringOperation("Hello, ", "World!");
            Console.WriteLine("String Concatenation: " + stringResult); // Output: Hello, World!

            // Using the delegate with doubles
            Operation<double> doubleOperation = Multiply;
            double doubleResult = doubleOperation(3.5, 2.0);
            Console.WriteLine("Double Multiplication: " + doubleResult); // Output: 7.0
        }
    }
}
