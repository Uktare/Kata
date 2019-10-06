namespace ParenthesisStringParser
{
    public class StringParser
    {
        public static bool Check(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return true;
            }

            var currentResult = false;

            for (var i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == '(' && text[i + 1] == ')' || text[i] == '[' && text[i + 1] == ']')
                {
                    currentResult = true;

                    var newText = text.Substring(0, i);

                    var offSet = i + 2;

                    if (offSet < text.Length)
                    {
                        newText += text.Substring(offSet, text.Length - (1 + offSet));
                    }

                    currentResult &= Check(newText);
                }
            }

            return currentResult;
        }
    }
}