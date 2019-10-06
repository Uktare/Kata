namespace ParenthesisStringParser
{
    public class StringParser
    {
        public static bool Check(string text)
        {
            if (text == "()")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}