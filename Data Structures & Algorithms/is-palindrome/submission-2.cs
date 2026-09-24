public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - (left + 1);
        // char[] inputString = s.ToArray();

        while (left < right)
        {
            if(!char.IsLetterOrDigit(s[left]))
            {
                left += 1;
                continue;
            }
            if(!char.IsLetterOrDigit(s[right]))
            {
                right -= 1;
                continue;
            }

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;  
            }
            
            right -= 1;
            left += 1;
        }

        return true;
    }
}
