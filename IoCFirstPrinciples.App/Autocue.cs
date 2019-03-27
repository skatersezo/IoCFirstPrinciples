using System;

namespace IoCFirstPrinciples.App
{
    public class Autocue
    {
        public const string YoureWrongMessage = "You're wrong!!!";
        private IClock _clock;

        public Autocue(SystemClock clock)
        {
            _clock = clock;
        }

        public string GetSomethingIntelligent()
        {
            var now = _clock.Now;

            if (now.DayOfWeek == DayOfWeek.Monday)
            {
                if (now.Hour >= 18)
                {
                    return "Go home!!!";
                }
                else if (now.Hour < 18)
                {
                    return "Work hard!!!";
                }
            }
            
            return YoureWrongMessage;
        }
    }
}