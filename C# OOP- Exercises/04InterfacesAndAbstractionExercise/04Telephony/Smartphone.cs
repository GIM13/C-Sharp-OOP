namespace _04Telephony
{
    public class Smartphone : ICall, IBrowse
    {
        public Smartphone(string input)
        {
            Input = input;
        }

        public string Input { get; set; }

        public string Browse()
        {
            return $"Browsing: {Input}";
        }

        public string Call()
        {
            return $"Calling... {Input}";
        }
    }
}
