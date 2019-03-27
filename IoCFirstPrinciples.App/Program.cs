using System;

namespace IoCFirstPrinciples.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // var manolo = new Manolo(new Autocue(new SystemClock()), new Megaphone());
            // var manolo = ManolosFactory.SpawnOne();
            var manolo = (Manolo) AutomaticFactory.GimmiOne(typeof(Manolo));
            manolo.ShoutSomething();

            Console.ReadKey();
        }
    }
}
