namespace Chapter4LINQ {
    // Explain the standard query operators "select", "contains", "orderBy" and "where" 
    // in LINQ with suitable example.

   class StudentInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }

    class PastQuestion3
    {
        static void Main()
        {
            // List of students
            List<StudentInfo> students = new List<StudentInfo>
            {
                new StudentInfo { Name = "John", Age = 21, City = "Kathmandu" },
                new StudentInfo { Name = "Alice", Age = 23, City = "Pokhara" },
                new StudentInfo { Name = "Bob", Age = 19, City = "Kirtipur" },
                new StudentInfo { Name = "David", Age = 22, City = "Kathmandu" },
                new StudentInfo { Name = "Charlie", Age = 20, City = "Lalitpur" }
            };

            // 1. Use Where to filter students living in Kathmandu
            var kathmanduStudents = students.Where(s => s.City == "Kathmandu");

            // 2. Use Select to project only the names of the students
            var studentNames = kathmanduStudents.Select(s => s.Name);

            // 3. Use Contains to check if the name "John" is in the filtered student list
            bool hasJohn = studentNames.Contains("John");

            // 4. Use OrderBy to sort students by Age
            var sortedStudents = students.OrderBy(s => s.Age);

            // Display the results
            Console.WriteLine("Students living in Kathmandu:");
            foreach (var name in studentNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nIs John in the list of Kathmandu students? " + hasJohn);

            Console.WriteLine("\nStudents sorted by age:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.Name}, Age: {student.Age}, City: {student.City}");
            }
        }
    }
}