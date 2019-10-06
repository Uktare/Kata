using System.Collections.Generic;

namespace ParenthesisStringParser
{
    public class StringParser
    {
        private readonly Dictionary<char, char> AuthorizedKeyValue = new Dictionary<char, char> { { '(', ')' }, { '[', ']' } };

        public bool Check(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return true;
            }

            var currentResult = false;

            for (var i = 0; i < text.Length - 1; i++)
            {
                if (AuthorizedKeyValue.TryGetValue(text[i], out var value) && text[i + 1] == value)
                {
                    currentResult = true;
                    var newText = CreateNewTextToCheck(text, i);

                    currentResult &= Check(newText);
                }
            }

            return currentResult;
        }

        private static string CreateNewTextToCheck(string text, int index)
        {
            var newText = text.Substring(0, index);
            var offSet = index + 2;

            if (offSet < text.Length)
            {
                newText += text.Substring(offSet, text.Length - (1 + offSet));
            }

            return newText;
        }
    }
}