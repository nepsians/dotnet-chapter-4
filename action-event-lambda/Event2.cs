namespace Chapter4
{
   public class CustomEventArgs : EventArgs
    {
        public string Message { get; }

        public CustomEventArgs(string message)
        {
            Message = message;
        }
    } 

    public delegate void CustomEventHandler(object sender, CustomEventArgs e);

    public class Publisher
    {
        public event CustomEventHandler? CustomEvent;

        public void DoWork()
        {
            CustomEventArgs args = new CustomEventArgs("Work is done");

            CustomEvent?.Invoke(this, args);
            // CustomEvent(this, args) // [EventArgs.Empty]
        }
    }

    public class Subscriber
    {
        public void OnCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine($"Event received with message: {e.Message}.");
        }
    }

    class Event2
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            publisher.CustomEvent += subscriber.OnCustomEvent;

            publisher.DoWork();

            publisher.CustomEvent -= subscriber.OnCustomEvent;
        }
    }
}