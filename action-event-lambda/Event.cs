using System;

namespace Chapter4 {
    public class Doorbell
    {
        public delegate void RingEventHandler(object sender, EventArgs e);
        
        public event RingEventHandler? Ring;

        public void Press()
        {
            Console.WriteLine("Doorbell pressed.");

            if (Ring != null)
            {
                Ring(this, EventArgs.Empty); 
            }
        }
    }

    public class Resident
    {
        public void OnDoorbellRing(object sender, EventArgs e)
        {
            Console.WriteLine("Resident: I'll get the door!");
        }
        public void InitiateCamRecorder(object sender, EventArgs e)
        {
            Console.WriteLine("Camera: Start recording the door!");
        }
    }

    public class Event
    {
        public static void Main()
        {
            Doorbell doorbell = new Doorbell();
            Resident resident = new Resident();

            doorbell.Ring += new Doorbell.RingEventHandler(
                resident.InitiateCamRecorder);
            doorbell.Ring += new Doorbell.RingEventHandler(
                resident.OnDoorbellRing);

            doorbell.Press();
        }
    }
}
