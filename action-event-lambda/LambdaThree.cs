namespace Chapter4 {
    public class LabmdaThree
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            ProcessNumbers(numbers, number => Console.WriteLine("Processing number: " + number));
        }

        public static void ProcessNumbers(List<int> numbers, Action<int> process)
        {
            foreach (int number in numbers)
            {
                process(number);
            }
        }
    }
}