namespace Chapter4{
    public class AnonymousOne
    {
        public delegate void PrintMessage(string message);

        // static void Print(string message){
        //     Console.WriteLine(message);
        // }

        public static void Main()
        {
            PrintMessage print = delegate (string message)
            {
                Console.WriteLine(message);
            };

            print("Hello, this is an anonymous method in C#!");
        }
    }
}