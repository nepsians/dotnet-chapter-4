namespace Chapter4 {
    public delegate void ClickEventHandler(object sender, EventArgs e);
    public class Button{
        public event ClickEventHandler? Click;
        public void OnClick(){
            Console.WriteLine("Button has been clicked");

            if(Click != null){
                Click(this, EventArgs.Empty);
            }
        }
    }
    public class EventExampleTwo{
        static void Main(){
            Button btn = new Button();
            btn.Click += new ClickEventHandler(Button_Clicked);

            btn.OnClick();
        }

        public static void Button_Clicked(object sender, EventArgs e){
            Console.WriteLine("Event Handler: Button has been clicked!!!");
        }
    }
}