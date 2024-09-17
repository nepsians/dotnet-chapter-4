namespace Chapter4LINQ {
    class Challenge1
    {
        static void Main()
        {
            // Filter and Sort Numbers Greater than 20
            int[] numbers = { 10, 45, 33, 20, 18, 9, 50, 27, 3 };

            var result = numbers.Where(n => n > 20)
                        .OrderByDescending(n => n);

            Console.WriteLine("Numbers greater than 20 in descending order:");
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}