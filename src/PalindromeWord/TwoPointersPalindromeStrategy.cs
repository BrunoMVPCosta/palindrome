using System;

namespace Palindrome
{
    public class TwoPointersPalindromeStrategy : IPalindromeStrategy
    {
        public bool IsValid(string word)
        {
            if (string.IsNullOrEmpty(word))
                throw new ArgumentNullException();

            int i = 0;
            int j = word.Length - 1;

            while (i < j)
            {
                if (word[i] != word[j])
                    return false;

                i++;
                j--;
            }

            return true;
        }
    }
}
