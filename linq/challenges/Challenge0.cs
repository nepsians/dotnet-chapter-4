namespace Chapter4LINQ {
    class Challenge0
    {
        static void Main()
        {
            int[] numbers = { 10, 45, 33, 20, 18, 9, 50, 27, 3 };

            var result = numbers.Where((n, index) => {
                Console.WriteLine($"Inside loop: {n} index: {index}");
                return n < 40 && n > 30 && n != 10;
            }).ToList();

            Console.WriteLine("-------------------");

            foreach (var number in result)
            {
                Console.WriteLine($"Result: {number}");
            }
        }
    }
}