namespace Chapter4LINQ {
    class Example2{
        public static void Main(){
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = from number in numbers
                            where number % 2 == 0
                            select number;

            var evenNumbersTwo = numbers.Where(num => num % 2 == 0);

            Console.WriteLine("Even Numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}

