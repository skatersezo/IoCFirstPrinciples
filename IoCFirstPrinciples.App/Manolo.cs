namespace IoCFirstPrinciples.App
{
    public class Manolo
    {
        private readonly Autocue _autocue;
        private readonly Megaphone _megaphone;

        public Manolo(Autocue autocue, Megaphone megaphone)
        {
            _autocue = autocue;
            _megaphone = megaphone;
        }

        public void ShoutSomething()
        {
            var message = _autocue.GetSomethingIntelligent();
            _megaphone.Shout(message);
        }
    }
}