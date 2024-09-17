namespace Chapter4LINQ {
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
    }

    class Enrollment
    {
        public int StudentID { get; set; }
        public string CourseName { get; set; }
    }

    class Advanced7
    {
        static void Main()
        {
            // List of students
            List<Student> students = new List<Student>
            {
                new Student { StudentID = 1, Name = "John" },
                new Student { StudentID = 2, Name = "Alice" },
                new Student { StudentID = 3, Name = "Bob" }
            };

            // List of enrollments
            List<Enrollment> enrollments = new List<Enrollment>
            {
                new Enrollment { StudentID = 1, CourseName = "Math" },
                new Enrollment { StudentID = 2, CourseName = "Science" },
                new Enrollment { StudentID = 3, CourseName = "History" },
                new Enrollment { StudentID = 1, CourseName = "Physics" }
            };

            // Join the students with enrollments based on StudentID
            var studentCourses = students.Join(enrollments,    // First collection
                                            student => student.StudentID,  // Key selector for the first collection (students)
                                            enrollment => enrollment.StudentID,  // Key selector for the second collection (enrollments)
                                            (student, enrollment) => new  // Result selector to project the result
                                            {
                                                student.Name,
                                                enrollment.CourseName
                                            });

            // Display the joined data
            foreach (var studentCourse in studentCourses)
            {
                Console.WriteLine($"{studentCourse.Name} is enrolled in {studentCourse.CourseName}");
            }
        }
    }
}