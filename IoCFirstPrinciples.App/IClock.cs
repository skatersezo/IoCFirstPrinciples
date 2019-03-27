using System;

namespace IoCFirstPrinciples.App
{
    public interface IClock
    {
        DateTime Now { get; }
    }
}