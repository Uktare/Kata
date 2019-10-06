using ParenthesisStringParser;
using Xunit;

namespace ParanthesisStringParser.Test
{
    public class StringParserShould
    {
        [Fact]
        public void ReturnTrueForOpenedClosedParanthesis()
        {
            const string correctString = "()";

            Assert.True(StringParser.Check(correctString));
        }

        [Fact]
        public void ReturnFalseTrueForClosedOpenedParanthesis()
        {
            const string incorrectString = ")(";

            Assert.False(StringParser.Check(incorrectString));
        }
    }
}
