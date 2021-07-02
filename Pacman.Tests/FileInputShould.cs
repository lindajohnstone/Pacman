using System;
using Xunit;

namespace Pacman.Tests
{
    public class FileInputShould
    {
        [Fact]
        public void ReturnString_GivenFileInput()
        {
            var input = new FileInput();
            var path = "testData/test.txt";
            var expected = "5,5\nWWWWW\nWPDDW\nWDWDW\nWEEGW\nWWWWW";

            var result = input.Read(path);

            Assert.Equal(expected, result);
        }
    }
}