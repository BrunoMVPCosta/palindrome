using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome.Tests
{
    [TestClass]
    public class ReserveArrayPalindromeStrategyTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsValid_WithNullString_ThrowsAnArgumentNullException()
        {
            ReserveArrayPalindromeStrategy validator = new ReserveArrayPalindromeStrategy();
            validator.IsValid(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsValid_WithEmptyString_ThrowsAnArgumentNullException()
        {
            ReserveArrayPalindromeStrategy validator = new ReserveArrayPalindromeStrategy();
            validator.IsValid(string.Empty);
        }

        [TestMethod]
        public void IsValid_WithNonPalindromeWord_ReturnsFalse()
        {
            const string word = "aabc";
            ReserveArrayPalindromeStrategy validator = new ReserveArrayPalindromeStrategy();
            bool result = validator.IsValid(word);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_WithPalindromeWord_ReturnsTrue()
        {
            const string word = "civic";
            ReserveArrayPalindromeStrategy validator = new ReserveArrayPalindromeStrategy();
            bool result = validator.IsValid(word);

            Assert.IsTrue(result);
        }
    }
}
