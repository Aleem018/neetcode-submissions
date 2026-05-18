public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length)
        {
            return false;
        }
        char[] string1 = s.ToCharArray();
        char[] string2 = t.ToCharArray();

        Array.Sort(string1);
        Array.Sort(string2);

        return(Enumerable.SequenceEqual(string1, string2));

    }
}
