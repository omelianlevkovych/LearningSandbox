using Sandbox.StudyCases;
using Sandbox.StudyCases.Interfaces;
using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var studyCase = new Equality();
            studyCase.Explore();

            Console.ReadKey();
        }
    }
}
