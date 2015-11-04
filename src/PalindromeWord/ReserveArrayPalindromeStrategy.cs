using System;

namespace Palindrome
{
    public class ReserveArrayPalindromeStrategy : IPalindromeStrategy
    {
        public bool IsValid(string word)
        {
            if (string.IsNullOrEmpty(word))
                throw new ArgumentNullException();

            char[] arrayWord = word.ToCharArray();
            Array.Reverse(arrayWord);
            string backwards = new string(arrayWord);

            return word == backwards;
        }
    }
}
