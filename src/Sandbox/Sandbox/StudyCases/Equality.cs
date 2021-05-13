using Sandbox.StudyCases.Interfaces;
using System;

namespace Sandbox.StudyCases
{
    /// <summary>
    /// The study case showing how in CLR and C# objects and types equality actually work.
    /// </summary>
    public sealed class Equality : IStudyCase
    {
        private class ExampleClass
        {
            public int Value { get; set; }

            public override bool Equals(object obj)
            {
                return obj is ExampleClass that && that.Value == Value;
            }
        }

        public static bool FirstCase()
        {
            var ref1 = new ExampleClass
            {
                Value = 1
            };

            var ref2 = new ExampleClass
            {
                Value = 1
            };

            return ref1 == ref2;
        }

        public static bool SecondCase()
        {
            var ref1 = new ExampleClass
            {
                Value = 1
            };

            var ref2 = new ExampleClass
            {
                Value = 1
            };

            return ref1.Equals(ref2);
        }

        public static bool ThirdCase()
        {
            var ref1 = new ExampleClass
            {
                Value = 1
            };

            var ref2 = new ExampleClass
            {
                Value = 1
            };

            return ReferenceEquals(ref1, ref2);
        }

        public void Explore()
        {
            Console.WriteLine(FirstCase());
            Console.WriteLine(SecondCase());
            Console.WriteLine(ThirdCase());
        }
    }
}
