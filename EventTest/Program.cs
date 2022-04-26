namespace EvenTtest
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Press T to click");
            var key = Console.ReadLine();
            if (key == "t")
            {
                Pressed();
            }

            static void Pressed()
            {
                Button button = new Button();
                button.Click += (s, e) =>
                {
                    Console.WriteLine("You clicked a button!");
                };
                button.OnClick();
            }

        }
    }

   
 //code for the eventhandler
    public class Button
    {
        public EventHandler Click;
        public void OnClick()
        {
            Click.Invoke(this, EventArgs.Empty);
        }
    }

   
}
