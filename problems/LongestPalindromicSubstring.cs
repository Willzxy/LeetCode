public class Solution {
    private static int ExpandAroundCenter(string s, int left, int right) {
        while (left >= 0 && right < s.Length && s[left] == s[right]) {
            left--;
            right++;
        }
        return right - left - 1;
    }

    public string LongestPalindrome(string original) {
        if (string.IsNullOrEmpty(original)) return "";

        int start = 0;
        int maxLength = 1;

        for (int i = 0; i < original.Length; i++) {
            int len1 = ExpandAroundCenter(original, i, i);
            int len2 = ExpandAroundCenter(original, i, i + 1);
            int len = Math.Max(len1, len2);

            if (len > maxLength) {
                start = i - (len - 1) / 2;
                maxLength = len;
            }
        }

        return original.Substring(start, maxLength);
    }
}