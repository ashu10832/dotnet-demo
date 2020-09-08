using firstlibrary;
using System;
using Xunit;

namespace FirstcoreProject
{
    public class test
    {
        [Fact]
        public void TestName()
        {
        //Given
        var obj = new firstlibrary.Addition();
        Assert.Equal("ok",obj.display());
        
        //When
        
        //Then
        }

    }
}