namespace Chapter4LINQ {
    class Example4{
        // Sorting a List of Names Alphabetically
        public static void Main(){
            List<string> names = new List<string> { "John", "Anna", "Zara", "Mark", "Emily" };

            var sortedNames = from name in names
                            orderby name
                            select name;

            Console.WriteLine("Sorted Names:");
            foreach (var name in sortedNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}

// var sortedNames = names.OrderBy(name => name);