namespace Chapter4LINQ {
    class Challenge5
    {
        static void Main()
        {
            // Sum of Positive and Negative Numbers
            int[] numbers = { -5, 7, -3, 10, -12, 6 };

            int positiveSum = numbers.Where(n => n > 0).Sum();
            int negativeSum = numbers.Where(n => n < 0).Sum();

            Console.WriteLine($"Sum of positive numbers: {positiveSum}");
            Console.WriteLine($"Sum of negative numbers: {negativeSum}");
        }
    }
}