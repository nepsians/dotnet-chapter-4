namespace Chapter4LINQ {
    class Example3{
        public static void Main(){
            string[] names = { "Nihal", "Hari", "Ram", "John", "Merry" };

            var query = from name in names
                            where name.Contains("a")
                            select name;

            var queryTwo = names.Where(name => name.Contains("a"));

            Console.WriteLine("Names:");
            foreach (var name in query)
            {
                Console.WriteLine(name);
            }
        }
    }
}
