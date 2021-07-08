using System;

namespace visual_studio_commands
{
    class Program
    {
        static void Main(string[] args)
        {
            ISomeInterface
                someInstance = new SomeClass("HelloWorld!");

            someInstance.Show();
        }
    }
}