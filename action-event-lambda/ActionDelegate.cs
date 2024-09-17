namespace Chapter4 {
    // public delegate void CustomDelegate(string value);

    public class ActionExample{
        public static void ShowMessage(string value){
            Console.WriteLine(value);
        }
        public static void ShowMessageTwo(string val1, string val2){
            Console.WriteLine(val1 + val2);
        }

        public static int Addition(int a, int b){
            return a + b;
        }
    

        static void Main(){
            // CustomDelegate del = ShowMessage;

            //First and second-> parameter: Last -> return type
            Func<int, int, int> add1 = Addition;
            int sum = add1(1,2);
            Console.WriteLine(sum);

            Action<string> action = ShowMessage;
            // 16 parameter limits
            Action<string, string> action2 = ShowMessageTwo;

            action("This is a custom message.");
            action2("This is using custom message", "action 2");

            // del("From custom delegate");
            Console.ReadKey();
        }
    }
}