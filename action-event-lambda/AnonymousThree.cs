namespace Chapter4{
    public class AnonymousThree
    {
        public delegate void Process(int number);
        public static void Main()
            {
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
                // Anonymous method as a callback method
                Process process = delegate (int number)
                {
                    Console.WriteLine("Processing number: " + number);
                };

                ProcessNumbers(numbers, process);
            }
        public static void ProcessNumbers(List<int> numbers, Process process)
            {
                foreach (int number in numbers)
                {
                    process(number);
                }
            }
    }
}