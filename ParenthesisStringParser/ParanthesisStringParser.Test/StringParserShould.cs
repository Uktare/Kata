using ParenthesisStringParser;
using Xunit;

namespace ParanthesisStringParser.Test
{
    public class StringParserShould
    {
        private readonly StringParser _parser;

        public StringParserShould()
        {
            _parser = new StringParser();
        }

        [Fact]
        public void ReturnTrueForNull()
        {
            const string textToCheck = null;

            Assert.True(_parser.Check(textToCheck));
        }

        [Fact]
        public void ReturnTrueForEmpty()
        {
            var textToCheck = string.Empty;

            Assert.True(_parser.Check(textToCheck));
        }

        [Fact]
        public void ReturnTrueForOpenedClosedParanthesis()
        {
            const string textToCheck = "()";

            Assert.True(_parser.Check(textToCheck));
        }

        [Fact]
        public void ReturnFalseClosedOpenedParanthesis()
        {
            const string textToCheck = ")(";

            Assert.False(_parser.Check(textToCheck));
        }

        [Fact]
        public void ReturnTrueForOpenedClosedParanthesisTwoTimes()
        {
            const string textToCheck = "()()";

            Assert.True(_parser.Check(textToCheck));
        }

        [Fact]
        public void ReturnTrueForOpenedClosedBracket()
        {
            const string textToCheck = "[]";

            Assert.True(_parser.Check(textToCheck));
        }

        [Fact]
        public void ReturnFalseForClosedOpenedBracket()
        {
            const string textToCheck = "][";

            Assert.False(_parser.Check(textToCheck));
        }

        [Fact]
        public void ReturnTrueForOpenedClosedBracketTwoTimes()
        {
            const string textToCheck = "[][]";

            Assert.True(_parser.Check(textToCheck));
        }

        [Fact]
        public void ReturnFalseForOpenedClosedMixed()
        {
            const string textToCheck = "(]";

            Assert.False(_parser.Check(textToCheck));
        }

        [Fact]
        public void ReturnFalseForClosedOpenedMixed()
        {
            const string textToCheck = "](";

            Assert.False(_parser.Check(textToCheck));
        }

        [Fact]
        public void ReturnTrueForOpenedClosedMixedTwoTimes()
        {
            const string textToCheck = "[]()";

            Assert.True(_parser.Check(textToCheck));
        }

        [Fact]
        public void ReturnFalseForIncorrectFirstAndEnd()
        {
            const string textToCheck = "(()]";

            Assert.False(_parser.Check(textToCheck));
        }

        [Theory]
        [InlineData("(()())")]
        [InlineData("(()[]))")]
        [InlineData("([(())()()])")]
        [InlineData("[[([()[]][([])])()]]")]
        public void ReturnTrueOnComplexCases(string textToCheck)
        {
            Assert.False(_parser.Check(textToCheck));
        }
    }
}