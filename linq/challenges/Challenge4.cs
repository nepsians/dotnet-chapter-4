namespace Chapter4LINQ {
    class Challenge4
    {
        static void Main()
        {
            // Count Odd and Even Numbers
            int[] numbers = { 2, 7, 18, 9, 24, 5, 33, 12 };

            int oddCount = numbers.Count(n => n % 2 != 0);
            int evenCount = numbers.Count(n => n % 2 == 0);

            Console.WriteLine($"Odd numbers count: {oddCount}");
            Console.WriteLine($"Even numbers count: {evenCount}");
        }
    }
}