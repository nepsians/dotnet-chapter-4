namespace Chapter4LINQ {
    class Example1 {
        public static void Main(){
            int[] numbers = { 1, 3, 5, 7, 9 };

            // Query Syntax
            var result = from num in numbers
                        where num > 5
                        select num;

            // Method Synatx(Lambda expression)
            var resultTwo = numbers.Where(num => num > 5);

            Console.WriteLine("Numbers greater than 5:");
            foreach (var number in resultTwo)
            {
                Console.WriteLine(number);
            }
        }
    }
}


// Method Synatx(Lambda expression)
// var resultTwo = numbers.Where(num => num > 5);