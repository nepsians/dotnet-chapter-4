namespace Chapter4 {
    public class ExceptionTwo{
        public static void Main()
        {
            try
            {
                int numerator = 10;
                int denominator = 0; 
                // int denominator = 10; 
                int result = numerator / denominator;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                Console.WriteLine("Exception message: " + ex.Message);
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }
    }
}