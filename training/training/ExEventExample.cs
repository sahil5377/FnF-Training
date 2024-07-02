using System;
using System.Threading.Channels;
using System.Threading;
namespace FrameworkExample
{
    class AlaramClock
    {
        public event Action OnAlaramTime;
        private readonly DateTime alaramTime;
        public AlaramClock(DateTime alaramTime) => this.alaramTime = alaramTime;
        public void DisplayClock()
        {
            if (DateTime.Now.Minute == alaramTime.Minute)
            {
                if (OnAlaramTime != null)
                    OnAlaramTime();
                else
                    Console.WriteLine("Event handler is not set");
            }
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
    }
    class EventsExample
    {
        static void testFunc()
        {
            Console.WriteLine("Test Func");
        }
        static void Main(string[] args)
        {
            ClockExample();
        }

        private static void ClockExample()
        {
            AlaramClock clock = new AlaramClock(DateTime.Now.AddMinutes(1));
            clock.OnAlaramTime += Clock_OnAlaramTime;
            do
            {
                clock.DisplayClock();
                Thread.Sleep(1000);
                Console.Clear();

            }while(true);
        }

        private static void Clock_OnAlaramTime()
        {
            Console.WriteLine("Lets Go for Break!!!");
        }

        private static void ActionExample()
        {
            Action example = () => Console.WriteLine("Using Anonymous methods");
            example();
        }
    }

}
