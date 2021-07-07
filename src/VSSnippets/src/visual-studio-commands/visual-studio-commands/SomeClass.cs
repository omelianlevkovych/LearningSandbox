namespace visual_studio_commands
{
    public class SomeClass : ISomeInterface
    {
        public string SomeValue { get; set; }

        public SomeClass(string someValue)
        {
            SomeValue = someValue;
        }

        public void Show()
        {
            System.Console.WriteLine(SomeValue);
        }
    }
}
