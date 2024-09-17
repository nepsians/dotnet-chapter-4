namespace Chapter4 {

    class EventPublisher
    {
        public event EventHandler? SomethingHappened;

        public void DoSomething()
        {
            Console.WriteLine("Doing something...");

            SomethingHappened?.Invoke(this, EventArgs.Empty);
        }
    }

    class LambdaEventsExample
    {
        static void Main()
        {
            EventPublisher publisher = new EventPublisher();

            publisher.SomethingHappened += (sender, e) =>
            {
                Console.WriteLine("Event handler called via lambda expression.");
            };

            publisher.DoSomething();
        }
    }

}