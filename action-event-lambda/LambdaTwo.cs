namespace Chapter4{
    public class LambdaTwo
    {
        static bool isEven(int number) => number % 2 == 0;

        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Even numbers:");

            foreach (int number in numbers)
            {
                if (isEven(number))
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}