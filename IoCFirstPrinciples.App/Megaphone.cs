using System;

namespace IoCFirstPrinciples.App
{
    public class Megaphone
    {
        public void Shout(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message.ToUpperInvariant());
        }
    }
}