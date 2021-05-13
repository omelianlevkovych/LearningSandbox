using Sandbox.StudyCases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox.StudyCases
{
    /// <summary>
    /// The study case showing how in CLR and C# objects and types equality actually work.
    /// </summary>
    public sealed class Equality : IStudyCase
    {
        public delegate bool ExecutionDelegate();
        private readonly List<(bool expectedResult, ExecutionDelegate)> cases;

        public Equality()
        {
            cases = new List<(bool, ExecutionDelegate)>
            {
                (false, new ExecutionDelegate(FirstCase)),
                (true, new ExecutionDelegate(SecondCase)),
                (false, new ExecutionDelegate(ThirdCase)),
            };
        }

        public List<(bool expectedResult, ExecutionDelegate)> Cases => cases;

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
            foreach (var methodCase in cases)
            {
                Console.WriteLine(methodCase.Item2.Invoke());
            }
        }
    }
}
