namespace IoCFirstPrinciples.App
{
    public class ManolosFactory
    {
        public static Manolo SpawnOne()
        {
            //  return new Manolo(new Autocue(new SystemClock()), new Megaphone());
            return new Manolo(AutocueFactory.BuildOne(), new Megaphone());

        }
    }
}