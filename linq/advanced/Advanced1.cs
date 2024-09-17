namespace Chapter4LINQ {
    class Advanced1
    {
        static void Main()
        {
            List<string> names = new List<string>() {"Nihal", "Ram", "Hari", "Shyam"};
            List<string> namesTwo = new List<string>() {"John", "Harry", "Janel", "Erin", "Nihal", "Ram"};

            // 1) outer 2) inner 3) outerKeySelector 4) innerKeySelector 5) resultSelector
            // Similar to inner join
            var result = names.Join(namesTwo, str1 => str1, str2 => str2, (str1, str2) => str2); 
            
            // Distinct result
            var resultUnion = names.Union(namesTwo);

            // Appends two sequence
            var resultConcat = names.Concat(namesTwo);

            foreach (var name in resultConcat)
            {
                Console.WriteLine(name);
            }
        }
    }
}