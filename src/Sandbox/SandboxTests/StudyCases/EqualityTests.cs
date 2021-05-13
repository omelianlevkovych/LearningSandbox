using Sandbox.StudyCases;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SandboxTests.StudyCases
{
    public sealed class EqualityTests
    {
        [Fact]
        public void VerifyRunAndExploreMethod()
        {
            // Arrange
            var studyCase = new Equality();

            // Act, Assert
            var results = studyCase.Cases;
            foreach (var item in results)
            {
                Assert.Equal(item.expectedResult, item.Item2.Invoke());
            }
        }
    }
}
