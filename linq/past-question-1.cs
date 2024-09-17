namespace Chapter4LINQ {
    // Write a program to select employees whose salary is greater than 20000 
    // and whose address is kathmandu using LINQ.
    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }

        public Employee(string name, decimal salary, string address) {
            Name = name;
            Salary = salary;
            Address = address;
        }
    }

    class PastQuestion1
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Nihal Shrestha", 25000, "Kathmandu"));
            employees.Add(new Employee("Hari Gurung", 15000, "Pokhara"));
            employees.Add(new Employee("Ram Shrestha", 30000, "Kathmandu"));
            employees.Add(new Employee("Geeta Maharjan", 18000, "Lalitpur"));
            employees.Add(new Employee("Reeta Shrestha", 22000, "Kathmandu"));

            var highSalaryEmployeesInKathmandu = employees
                .Where(emp => emp.Salary > 20000 && emp.Address == "Kathmandu");

            Console.WriteLine("Employees with salary > 20000 and living in Kathmandu:");
            foreach (var employee in highSalaryEmployeesInKathmandu)
            {
                Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}, Address: {employee.Address}");
            }
        }
    }
}