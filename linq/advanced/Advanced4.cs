namespace Chapter4LINQ {
    class StudentThree {
        public string Name { get; set; }
        public string Grade { get; set; }

        public StudentThree(string name, string grade) {
            Name = name;
            Grade = grade;
        }
    }

    class Advanced4
    {
        static void Main()
        {
            List<StudentThree> students = new List<StudentThree>(){
                new StudentThree("Alice", "A"),
                new StudentThree("Bob", "B"),
                new StudentThree("Charlie", "A"),
                new StudentThree("David", "C"),
                new StudentThree("Eve", "B")
            };

            // Group students by their grade
            // var groupedStudentsQuery = from student in students
            //                             group student by student.Grade;
            var groupedStudents = students.GroupBy(s => s.Grade);

            // Display students grouped by grade
            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Grade: {group.Key}, Total count: {group.Count()}");

                foreach (var student in group)
                {
                    Console.WriteLine($"  Student: {student.Name}");
                }
            }
        }
    }
}