namespace Chapter4 {
    class Lambda {
        static int Show() => 5; // Expression Lambda
        // static int Show(){
        //     return 5;
        // }
        static int Add(int x, int y) => x + y; // Expression Lambda
        // static int Add(int x, int y){
        //     return x+y;
        // }
        static string Print(string firstName, string lastName) => firstName + lastName;
        delegate void ModifyNum(int inputNum);
        static void Main(){
            int value = Show(); // 5
            int addResult = Add(2,2); // 4
            string fullName = Print("Nihal", "Shrestha");

            ModifyNum change = x => { // Statement Lambda
                int result = x + 1;
                Console.WriteLine($"Result: {result}");
            };
            change(5);
        }
    }
}