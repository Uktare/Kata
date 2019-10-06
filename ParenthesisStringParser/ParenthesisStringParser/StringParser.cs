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

            if (text.Contains("()") || text.Contains("[]"))
            {
                return true;
            }
            {
                return false;
            }
        }
    }
}