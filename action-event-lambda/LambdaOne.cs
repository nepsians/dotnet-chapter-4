namespace Chapter4{
    public class LambdaOne
    {
        public delegate void PrintMessage(string message);

        static int Sum(int a, int b) => a+b;

        public static void Main()
        {
            PrintMessage print = delegate (string message)
            {
                Console.WriteLine(message);
            };

            print("Hello, this is an anonymous method in C#!");
        }
    }
}