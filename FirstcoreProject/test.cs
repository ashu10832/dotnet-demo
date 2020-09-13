using System;
using Xunit;
using firstlibrary;

namespace FirstcoreProject
{
    public class test
    {
        [Fact]
        public void shouldAddTwoNumbers()
        {
        var cal = new firstlibrary.Calculator();
        Assert.Equal(5,cal.add(2,3));
        }

        [Fact]
        public void shouldSubtractTwoNumbers()
        {
        var cal = new firstlibrary.Calculator();
        Assert.Equal(7,cal.subtract(10,3));
        }

        [Fact]
        public void shouldMultiplyTwoNumbers()
        {
        var cal = new firstlibrary.Calculator();
        Assert.Equal(30,cal.multiply(10,3));
        }

    }
}