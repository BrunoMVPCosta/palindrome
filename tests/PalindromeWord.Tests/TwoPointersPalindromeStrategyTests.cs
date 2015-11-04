using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome.Tests
{
    [TestClass]
    public class PalindromeValidatorTwoPointersTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsValid_WithNullString_ThrowsAnArgumentNullException()
        {
            TwoPointersPalindromeStrategy validator = new TwoPointersPalindromeStrategy();
            validator.IsValid(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsValid_WithEmptyString_ThrowsAnArgumentNullException()
        {
            TwoPointersPalindromeStrategy validator = new TwoPointersPalindromeStrategy();
            validator.IsValid(string.Empty);
        }

        [TestMethod]
        public void IsValid_WithNonPalindromeWord_ReturnsFalse()
        {
            const string word = "aabc";
            TwoPointersPalindromeStrategy validator = new TwoPointersPalindromeStrategy();
            bool result = validator.IsValid(word);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_WithPalindromeWord_ReturnsTrue()
        {
            const string word = "civic";
            TwoPointersPalindromeStrategy validator = new TwoPointersPalindromeStrategy();
            bool result = validator.IsValid(word);

            Assert.IsTrue(result);
        }
    }
}
