namespace Chapter4LINQ {
    class Challenge7
    {
        static void Main()
        {
            int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13 };

            var primeNumbers = numbers.Where(IsPrime);

            Console.WriteLine("Prime numbers:");
            foreach (var num in primeNumbers)
            {
                Console.WriteLine(num);
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}