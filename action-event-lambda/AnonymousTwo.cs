namespace Chapter4{
    public class AnonymousTwo
    {
        public delegate bool Filter(int number);
        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Filter isEven = delegate (int number)
            {
                return number % 2 == 0;
            };

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