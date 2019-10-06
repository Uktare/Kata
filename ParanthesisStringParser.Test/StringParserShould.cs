using ParenthesisStringParser;
using Xunit;

namespace ParanthesisStringParser.Test
{
    public class StringParserShould
    {
        [Fact]
        public void ReturnTrueForOpenClosedParanthesis()
        {
            const string correctString = "()";

            Assert.True(StringParser.Check(correctString));
        }
    }
}
