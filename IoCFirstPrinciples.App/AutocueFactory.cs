namespace IoCFirstPrinciples.App
{
    public class AutocueFactory
    {
        public static Autocue BuildOne()
        {
            return new Autocue(new SystemClock());
        }
    }
}