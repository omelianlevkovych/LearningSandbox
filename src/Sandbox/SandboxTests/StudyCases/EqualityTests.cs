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
            Assert.False(Equality.FirstCase());
            Assert.True(Equality.SecondCase());
            Assert.False(Equality.ThirdCase());
        }
    }
}
