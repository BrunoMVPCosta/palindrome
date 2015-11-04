using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class PalindromeValidator
    {
        private readonly IPalindromeStrategy validatorStrategy;

        public PalindromeValidator(IPalindromeStrategy validatorStrategy)
        {
            if (validatorStrategy == null)
                throw new ArgumentNullException();

            this.validatorStrategy = validatorStrategy;
        }

        public bool IsValid(string word)
        {
            return validatorStrategy.IsValid(word);
        }
    }
}
