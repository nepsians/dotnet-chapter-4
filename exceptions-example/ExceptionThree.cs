namespace Chapter4 {
    public class ExceptionThree{
        public static void Main()
        {
            try
            {
                int[] numbers = { 10, 22, 31 };
                int index = 3; 
                Console.WriteLine(numbers[index]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: Index out of range.");
                Console.WriteLine("Exception message: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine("Exception message: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }
    }
}