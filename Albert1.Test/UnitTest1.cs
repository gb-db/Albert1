using System;
using Xunit;

namespace Albert1.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //A1 Arrange


            //A2 Act

            var c = true;
            //A3 Assert
            Assert.True(true == c, "That is it !");
        }
    }
}
