namespace Chapter4LINQ {
    class StudentTwo {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public StudentTwo(string name, int age, double grade) {
            Name = name;
            Age = age;
            Grade = grade;
        }
    }
    class Advanced3
    {
        static void Main()
        {
            List<StudentTwo> students = new List<StudentTwo>(){
                new StudentTwo("Alice", 20, 88 ),
                new StudentTwo ( "Bob",  17, 92),
                new StudentTwo ( "Charlie", 18, 85),
                new StudentTwo ( "Dave",  21, 95)
            };

            // Filter students above 18 and sort by grade in descending order
            var filteredStudents = students
                .Where(s => s.Age >= 18)
                .OrderByDescending(s => s.Grade);

            Console.WriteLine("Students over 18, sorted by grade:");
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.Name}, Age: {student.Age}, Grade: {student.Grade}");
            }
        }
    }
}