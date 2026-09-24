public class Solution {
    public bool IsPalindrome(string s) {
        char[] inputString = s.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray();
        char[] copy = (char[])inputString.Clone();
        Array.Reverse(copy);


        for(int i = 0; i <inputString.Length / 2; i++)
        {
            if (inputString[i] != copy[i])
            {
                return false;
            } else
            {
                continue;
            }
        }
        return true;
    }
}
