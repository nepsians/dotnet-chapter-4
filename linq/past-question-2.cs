// namespace Chapter4LINQ {
//     // Write a program to select students who are living in 
//     // kirtipur and studied in patan multiple campus using linq.

//    class StudentDetail
//     {
//         public string Name { get; set; }
//         public string Address { get; set; }
//         public string Campus { get; set; }

//         public StudentDetail(string name, string address, string campus){
//             Name = name;
//             Address = address;
//             Campus = campus;
//         }
//     }

//     class PastQuestion2
//     {
//         static void Main()
//         {
//             List<StudentDetail> students = new List<StudentDetail>();
//             students.Add(new StudentDetail("Hari", "Kirtipur", "Patan Multiple Campus"));
//             students.Add(new StudentDetail("Agrim", "Bhaktapur", "Patan Multiple Campus"));
//             students.Add(new StudentDetail("Sonesh", "Kirtipur", "Kathmandu University"));
//             students.Add(new StudentDetail("Nihal", "Kirtipur", "Patan Multiple Campus"));
//             students.Add(new StudentDetail("Shreja", "Lalitpur", "Patan Multiple Campus"));

//             var studentsFromKirtipurAndPatanCampus = students
//                 .Where(student => student.Address == "Kirtipur" && student.Campus == "Patan Multiple Campus");

//             Console.WriteLine("Students living in Kirtipur and studied at Patan Multiple Campus:");
//             foreach (var student in studentsFromKirtipurAndPatanCampus)
//             {
//                 Console.WriteLine($"Name: {student.Name}, Address: {student.Address}, Campus: {student.Campus}");
//             }
//         }
//     }
// }