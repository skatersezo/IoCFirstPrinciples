
using System;
using IoCFirstPrinciples.App;
using NUnit.Framework;
using Shouldly;

namespace IoCFirstPrinciples.UnitTests
{
    [TestFixture]
    public class WhenReadingTheAutocueOnSaturday
    {
        [Test]
        public void TheMessageShouldBeYouAreWrong()
        {
            IClock clock = new SaturdayClock();
            var autocue = new Autocue(clock);

            var message = autocue.GetSomethingIntelligent();

            message.ShouldBe(Autocue.YoureWrongMessage);
        }
    }

    public class SaturdayClock : IClock
    {
        public DateTime Now
        {
            get { return new DateTime(2019, 03, 27, 13, 00, 00);}
        }
    }
}
