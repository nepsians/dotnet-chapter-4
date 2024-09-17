namespace Chapter4LINQ {
    class StudentOne {
        public int id { get; set;}
        public string name { get; set;}
        public string address { get; set;}

        public StudentOne(int id, string name, string address) {
            this.id = id;
            this.name = name;
            this.address = address;
        }
    }
    class Advanced2
    {
        static void Main()
        {
            List<StudentOne> students = new List<StudentOne>();
            students.Add(new StudentOne(100, "Nihal Shrestha","Lagankhel"));
            students.Add(new StudentOne(101, "Ram Gurung", "Bhaktapur"));
            students.Add(new StudentOne(102, "Adam Shrestha", "Kathmandu"));
            students.Add(new StudentOne(103, "Neha Bajracharya", "Lagankhel"));
            students.Add(new StudentOne(104, "Asta Shrestha", "Patan"));

            var filteredStudents = students.Where(student => student.address.Contains("Lagankhel"));
            var maxId = students.Max(student => student.id);
            var count = students.Count();
            
            Console.WriteLine("MaxId in the list is: " + maxId);
            Console.WriteLine("Total count: " + count);

            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"Id: {student.id} Name: {student.name}");
            }
        }
    }
}