namespace Chapter4 {
    public delegate void DelEventHandler(); // Delegate is needed for event
    public class EventExampleOne{
        public static event DelEventHandler? add; // Events
        static void USA(){
            Console.WriteLine("Country: USA");
        }
        static void Nepal(){
            Console.WriteLine("Country: Nepal");
        }
        static void Japan(){
            Console.WriteLine("Country: Japan");
        }
        static void Main(){
            add += USA; // new DelEventHandler(USA);
            add += Nepal; // new DelEventHandler(Nepal);
            add += Japan; // new DelEventHandler(Japen);

            add();
        }
    }
}