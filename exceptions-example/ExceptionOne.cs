namespace Chapter4 {
    public class ExceptionOne
    {
        static void Display(string? name){
            if(name == null){
                throw new Exception($"{nameof (name)} is null");
            }
            Console.WriteLine(name);
        }
        public static void Main()
        {
            try
            {
                Display("Hello World");
                // Display(null);
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