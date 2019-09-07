using System;
using System.Collections.Generic;
using NUnit.Framework;
using Exercises;

namespace Tests
{
    [TestFixture]
    public class StringAndNumUtilityExperimentTests
    {
        private Dictionary<string, int[,]> _testData;

        [SetUp]
        public void Init()
        {
            _testData = new Dictionary<string, int[,]>
            {
                {"{{0}, {1}}", new int[2, 1] {{0}, {1}}},
                {"{{0, 4, 4}, {1, 5, 6}}", new int[2, 3] {{0, 4, 4}, {1, 5, 6}}}
            };
        }

        [Test]
        public void RemoveCharacterFromString()
        {
            Assert.AreEqual("wresource", StringAndNumUtility.RemoveChar('3', "w3resource"));
            Assert.AreEqual("3resource", StringAndNumUtility.RemoveChar('w', "w3resource"));
            Assert.AreEqual("w3rsourc", StringAndNumUtility.RemoveChar('e', "w3resource"));
            Assert.AreEqual("w3resource", StringAndNumUtility.RemoveChar('p', "w3resource"));
        }

        [Test]
        public void SwapFirstAndLastCharactersFromString()
        {
            Assert.AreEqual("e3resourcw", StringAndNumUtility.SwapFirstAndLastCharacters("w3resource"));
            Assert.AreEqual("nythoP", StringAndNumUtility.SwapFirstAndLastCharacters("Python"));
            Assert.AreEqual("x", StringAndNumUtility.SwapFirstAndLastCharacters("x"));
        }

        [Test]
        public void AddFirstCharacterToFrontAndBackOfString()
        {
            Assert.AreEqual("TThe quick brown fox jumps over the lazy dog.T",
                StringAndNumUtility.AddFirstCharacterToFrontAndBack("The quick brown fox jumps over the lazy dog."));
        }

        [Test]
        public void IsOneNumberNegativeAndOneNumberPositive()
        {
            Assert.IsTrue(StringAndNumUtility.IsOneNumberNegativeAndOneNumberPositive(-5, 20));
            Assert.IsTrue(StringAndNumUtility.IsOneNumberNegativeAndOneNumberPositive(20, -5));
            Assert.IsFalse(StringAndNumUtility.IsOneNumberNegativeAndOneNumberPositive(0, -5));
            Assert.IsFalse(StringAndNumUtility.IsOneNumberNegativeAndOneNumberPositive(20, 0));
            Assert.IsFalse(StringAndNumUtility.IsOneNumberNegativeAndOneNumberPositive(20, 15));
            Assert.IsFalse(StringAndNumUtility.IsOneNumberNegativeAndOneNumberPositive(-20, -15));
        }

        [Test]
        public void CalculateDifferenceBetweenValues()
        {
            Assert.AreEqual(20, StringAndNumUtility.CalculateTheAbsoluteValueDifferenceBetween(20, 40));
            Assert.AreEqual(40, StringAndNumUtility.CalculateTheAbsoluteValueDifferenceBetween(40, 20));
            Assert.AreEqual(0, StringAndNumUtility.CalculateTheAbsoluteValueDifferenceBetween(20, 20));
        }

        [Test]
        public void CalculateIfNumberIsWithin20Of100Or200()
        {
            Assert.IsTrue(StringAndNumUtility.CalculateNumberIsWithin20Of100Or200(100));
            Assert.IsTrue(StringAndNumUtility.CalculateNumberIsWithin20Of100Or200(200));
            Assert.IsTrue(StringAndNumUtility.CalculateNumberIsWithin20Of100Or200(120));
            Assert.IsFalse(StringAndNumUtility.CalculateNumberIsWithin20Of100Or200(121));
            Assert.IsTrue(StringAndNumUtility.CalculateNumberIsWithin20Of100Or200(80));
            Assert.IsFalse(StringAndNumUtility.CalculateNumberIsWithin20Of100Or200(79));
            Assert.IsTrue(StringAndNumUtility.CalculateNumberIsWithin20Of100Or200(220));
            Assert.IsFalse(StringAndNumUtility.CalculateNumberIsWithin20Of100Or200(221));
            Assert.IsTrue(StringAndNumUtility.CalculateNumberIsWithin20Of100Or200(180));
            Assert.IsFalse(StringAndNumUtility.CalculateNumberIsWithin20Of100Or200(179));
        }

        [Test]
        public void FindTheLongestWordInAString()
        {
            Assert.AreEqual("following",
                StringAndNumUtility.FindTheLongestWord(
                    "Write a C# Sharp Program to display the following pattern using the alphabet."));
        }

        [Test]
        public void PrintOddNumbers()
        {
            int[] result = StringAndNumUtility.GetOddNumbersToMaximumOf(50);
            Assert.AreEqual(25, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(5, result[2]);
            Assert.AreEqual(7, result[3]);
            Assert.AreEqual(9, result[4]);
            Assert.AreEqual(11, result[5]);
            Assert.AreEqual(13, result[6]);
            Assert.AreEqual(15, result[7]);
            Assert.AreEqual(17, result[8]);
            Assert.AreEqual(19, result[9]);
            Assert.AreEqual(21, result[10]);
            Assert.AreEqual(23, result[11]);
            Assert.AreEqual(25, result[12]);
            Assert.AreEqual(27, result[13]);
            Assert.AreEqual(29, result[14]);
            Assert.AreEqual(31, result[15]);
            Assert.AreEqual(33, result[16]);
            Assert.AreEqual(35, result[17]);
            Assert.AreEqual(37, result[18]);
            Assert.AreEqual(39, result[19]);
            Assert.AreEqual(41, result[20]);
            Assert.AreEqual(43, result[21]);
            Assert.AreEqual(45, result[22]);
            Assert.AreEqual(47, result[23]);
            Assert.AreEqual(49, result[24]);
        }

        [Test]
        public void PrintSumOfFirst500PrimeNumbers()
        {
            Assert.AreEqual(824693, StringAndNumUtility.CalculateSumOfPrimeNumbersForFirst(500));
        }

        [TestCase(false, 0)]
        [TestCase(false, 1)]
        [TestCase(true, 2)]
        [TestCase(false, 9)]
        [TestCase(true, 11)]
        [TestCase(false, 12)]
        [TestCase(true, 13)]
        public void IsPrime(bool expected, int input)
        {
            Assert.AreEqual(expected, StringAndNumUtility.IsPrime(input));
        }

        [TestCase(5, 23)]
        [TestCase(12, 237)]
        [TestCase(6, 15)]
        [TestCase(17, 539)]
        [TestCase(31, 83848)]
        [TestCase(0, 0)]
        public void CalculateSumOfDigitsInAnInteger(int expected, int input)
        {
            Assert.AreEqual(expected, StringAndNumUtility.CalculateDigitsInAnInteger(input));
        }

        [TestCase(75, "/Users/tracey.steinbach/Library/Preferences/Rider2019.2/scratches/TempFile.txt")]
        [TestCase(4099, "/Users/tracey.steinbach/Library/Preferences/Rider2019.2/scratches/TempFileLarge.txt")]
        public void CalculateFileSize(int expected, string input)
        {
            Assert.AreEqual(expected, StringAndNumUtility.GetFileSize(input));
        }

        [TestCase(1200, "4B0")]
        [TestCase(10, "A")]
        public void ConvertHexToDecimal(decimal expected, string input)
        {
            Assert.AreEqual(expected, StringAndNumUtility.ConvertHexToDecimal(input));
        }

        [TestCase("1B26D", 111213)]
        [TestCase("233D", 9021)]
        public void ConvertDecimalToHex(string expected, int input)
        {
            Assert.AreEqual(expected, StringAndNumUtility.ConvertDecimalToHex(input));
        }

        [Test]
        public void MultipleNumbers()
        {
            Assert.AreEqual(new int[] {4, 25, -3, 36},
                StringAndNumUtility.Multiply(new int[] {2, 5, -3, 6}, new int[] {2, 5, 1, 6}));
        }

        [Test]
        public void VerifyMultipleNumbersWhenNullArguments()
        {
            Assert.Throws<NullReferenceException>((() => StringAndNumUtility.Multiply(null, arrayTwo: new int[] {2})));
            Assert.Throws<NullReferenceException>((() => StringAndNumUtility.Multiply(new int[] {10}, arrayTwo: null)));
        }

        [Test]
        public void VerifyMultipleNumbersWhenEmptyArguments()
        {
            Assert.AreEqual(new int[] { }, StringAndNumUtility.Multiply(new int[] { }, new int[] { }));
        }

        [Test]
        public void VerifyMultiplyNumbersWhenDifferentSizeArrays()
        {
            Assert.Throws<ArgumentOutOfRangeException>((() =>
                StringAndNumUtility.Multiply(new int[] {2, 1}, arrayTwo: new int[] {2})));
        }

        [TestCase(0, "{{0}, {1}}")]
        [TestCase(19, "{{0, 4, 4}, {1, 5, 6}}")]
        public void SumMatrixExceptBelowZero(int expected, string input)
        {
            Assert.AreEqual(expected, StringAndNumUtility.SumMatrix(_testData[input]));
        }

//        [TestCase(new int[] {2, 3, 4, 7, 9}, new int[] {3, -5, 2, 9, 7, -5, 4})]
        [TestCase(new int[] {2, 3}, new int[] {3, -5, 2})]
        [TestCase(new int[] {2, 3}, new int[] {3, 2})]
        [TestCase(new int[] {1, 2}, new int[] {1, 2})]
        public void SortInAscendingOrder(int[] expected, int[] input)
        {
            Assert.AreEqual(expected, StringAndNumUtility.Order(input));
        }

        [TestCase(new int[] {9, 7, 4, 3, 2}, new int[] {3, -5, 2, 9, 7, -5, 4})]
        [TestCase(new int[] {3, 2}, new int[] {3, -5, 2})]
        [TestCase(new int[] {3, 2}, new int[] {3, 2})]
        [TestCase(new int[] {2, 1}, new int[] {1, 2})]
        public void SortInDescendingOrder(int[] expected, int[] input)
        {
            Assert.AreEqual(expected, StringAndNumUtility.OrderDescending(input));
        }

        [Test]
        public void TheNumbersThatAreDivisibleByTwoExtensionMethodApproach()
        {
            var input = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var expected = new int[] {0, 2, 4, 6, 8, 10};
            
            Assert.AreEqual(expected, StringAndNumUtility.RetrieveDivisibleByTwo(input));
        }

        [Test]
        public void TheNumbersThatAreDivisibleByTwoSqlApproach()
        {
            var input = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var expected = new int[] {0, 2, 4, 6, 8, 10};
            
            Assert.AreEqual(expected, StringAndNumUtility.RetrieveDivisibleByTwoSql(input));
        }

        [TestCase(new int[] {2, 3, 4, 5, 6}, new int[] {4, 9, 16, 25, 36}, true)]
        [TestCase(new int[] {2, 3, 4, 5, 6}, new int[] {1, 9, 16, 20, 24}, false)]
        [TestCase(new int[] {2, 3, 4, 5, 6}, new int[] {4, 9, 16, 20, 20}, false)]
        [TestCase(new int[] {1, 5, 3}, new int[] {1, 25, 9, 9}, false)]
        public void TestForSqaures(int[] numbers, int[] squares, bool expected)
        {
            Assert.AreEqual(expected, StringAndNumUtility.AreSquare(numbers, squares));
        }

        
        [TestCase(new int[] {2, 3, 4, 5, 6}, new int[] {4, 9, 16, 25, 36}, true)]
        [TestCase(new int[] {2, 3, 4, 5, 6}, new int[] {1, 9, 16, 20, 24}, false)]
        [TestCase(new int[] {2, 3, 4, 5, 6}, new int[] {4, 9, 16, 20, 20}, false)]
        [TestCase(new int[] {1, 5, 3}, new int[] {1, 25, 9, 9}, false)]
        public void TestForSqauresFast(int[] numbers, int[] squares, bool expected)
        {
            Assert.AreEqual(expected, StringAndNumUtility.AreSquareFast(numbers, squares));
        }

        [TestCase(new int[] {2, 3, 4, 5, 6}, new int[] {4, 9, 16, 25, 36}, true)]
        [TestCase(new int[] {2, 3, 4, 5, 6}, new int[] {1, 9, 16, 20, 24}, false)]
        [TestCase(new int[] {2, 3, 4, 5, 6}, new int[] {4, 9, 16, 20, 20}, false)]
        [TestCase(new int[] {1, 5, 3}, new int[] {1, 25, 9, 9}, false)]
        public void TestForSqauresYield(int[] numbers, int[] squares, bool expected)
        {
            Assert.AreEqual(expected, StringAndNumUtility.AreSquareYield(numbers, squares));
        }
        
        [TestCase(new string[]{"RemovE", "all","word","that","do","not","contain","the","lettEr","E"}, "The last word is the")]
        [TestCase(new string[]{"The","fox","jumped","over","the","box"}, "The last word is The")]
        [TestCase(new string[]{"Noe","Worde","Withe","Noe","e"}, "The last word is Worde")]
        [TestCase(new string[]{"No","Word","With","You","Know","what"}, "")]
        [TestCase(new string[]{"he","she","it","we","you","they"}, "The last word is we")]
        public void TestFindLastWord(string[] input, string expected)
        {
            Assert.AreEqual(expected, StringAndNumUtility.FindLastWord(input));
        }
    }
}