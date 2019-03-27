using System;

namespace IoCFirstPrinciples.App
{
    public class SystemClock : IClock
    {
        public DateTime Now
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}