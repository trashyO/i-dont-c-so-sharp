using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercises
{
    public class StringAndNumUtility
    {
        public static string RemoveChar(char charToRemove, string input)
        {
            string output = input;
            int indexOf;
                
            while ((indexOf = output.IndexOf(charToRemove)) != -1)
            {
                output = output.Remove(indexOf, 1);
            }

            return output;
        }

        public static string SwapFirstAndLastCharacters(string input)
        {
            char[] inputChars = input.ToCharArray();
            var firstChar = inputChars[0];
            var lastChar = inputChars[input.Length - 1];
            
            inputChars[0] = lastChar;
            inputChars[input.Length - 1] = firstChar;
            
            return new string(inputChars);
        }

        public static string AddFirstCharacterToFrontAndBack(string input)
        {
            char[] inputChars = input.ToCharArray();
            var firstChar = inputChars[0];
            
            string output = firstChar + input + firstChar;
            return output;
        }

        public static bool? IsOneNumberNegativeAndOneNumberPositive(int firstNumber, int secondNumber)
        {
            if (firstNumber < 0)
            {
                if (secondNumber > 0) return true;
            }
            else if (firstNumber > 0)
            {
                if (secondNumber < 0) return true;
            }

            return false;
        }

        public static int CalculateTheAbsoluteValueDifferenceBetween(int valueOne, int valueTwo)
        {
            int output = Math.Abs(valueOne - valueTwo);
            
            if (valueOne > valueTwo)
            {
                output *= 2;
            }

            return output;
        }

        public static bool? CalculateNumberIsWithin20Of100Or200(int input)
        {
//            if ((input - 100 <= 20 && input - 100 >= -20) || (input + 20 <= 120 && input >= 80)) return true;
//
//            if ((input - 200 <= 20 && input -200 >= -20) || (input + 20 <= 220 && input >= 180)) return true;
//
//            return false;

            return (Math.Abs(input - 100) <= 20 || Math.Abs(input - 200) <= 20);
        }

        public static string FindTheLongestWord(string input)
        {
            string[] words = input.Split(new[] {' '});
            string longestWord = words[0];
            
            foreach (var word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            return longestWord;
        }

        public static int[] GetOddNumbersToMaximumOf(int input)
        {
            int[] result = new int[input / 2];

            for (int currentInput = 1, index = 0; currentInput <= input; currentInput++)
            {
                if (currentInput % 2 != 0)
                {
                    result[index] = currentInput;
                    index++;
                }
            }
            
            return result;
        }

        public static int CalculateSumOfPrimeNumbersForFirst(int countOfPrimeNumbers)
        {
            int sum = 0;
            int primeNumbersFound = 0;
            
            for (int i = 0; primeNumbersFound < countOfPrimeNumbers; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                    primeNumbersFound++;
                }
            }
            Console.WriteLine("Prime numbers found {0}", primeNumbersFound);
            return sum;
        }


        public static bool IsPrime(int input)
        {
            if (input < 2) return false;
            if (input == 2) return true;
            if (input % 2 == 0) return false;
            
            int boundary = (int) Math.Floor(Math.Sqrt(input));

            for (int i = 2; i <= boundary; ++i)
            {
                if (input % i == 0) return false;  
            }
            
            return true;
        }

        public static int CalculateDigitsInAnInteger(int inputNumber)
        {
            char[] numbers = inputNumber.ToString().ToCharArray();

            int sum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Convert.ToInt32(Convert.ToString(numbers[i]));
            }

            return sum;
        }

        public static long GetFileSize(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            return fileInfo.Length;
        }

        public static int ConvertHexToDecimal(string input)
        {
            int result = int.Parse(input, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Converting {0} hex to decimal {1}", input, result);
            return result;
        }

        public static string ConvertDecimalToHex(int input)
        {
            string result = input.ToString("X");
            Console.WriteLine("Converting {0} decimal to hex {1}", input, result);
            return result;
        }

        public static int[] Multiply(int[] arrayOne, int[] arrayTwo)
        {
            if (arrayOne.Length != arrayTwo.Length)
            {
                Console.WriteLine($"Array lengths are different. {arrayOne} length is {arrayOne.Length} where {arrayTwo} length is {arrayTwo.Length}");
                throw new ArgumentOutOfRangeException($"Array lengths are different. {arrayOne} length is {arrayOne.Length} where {arrayTwo} length is {arrayTwo.Length}");
            }
            
            int[] result = new int[arrayOne.Length];
            
            for (int i = 0; i < arrayOne.Length; i++)
            {
                result[i] = arrayOne[i] * arrayTwo[i];
            }

            return result;
        }

        public static int SumMatrix(int[,] input)
        {
            int sum = 0;
            
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Console.WriteLine("Loop {0}{1}", i, j);
                    
                    if ((i != 0 && input[i - 1, j] != 0) || i == 0)
                    {
                        // Not the first tuple, which means there are tuples above us. Only sum if no zero above us.
                        Console.WriteLine("Not first row. Sum: {0} + Current: {1} = {2}", sum, input[i,j], sum + input[i,j]);
                        sum += input[i, j];
                    }
                }
                
            }
            return sum;
        }

        public static int[] Order(int[] input)
        {
            List<int> results = new List<int>();
            foreach (var i in input.Where(item => item != -5)
                .OrderBy(item => item))
            {
                results.Add(i);
            }

            return results.ToArray();
        }

        public static int[] OrderDescending(int[] input)
        {
            List<int> results = new List<int>();
            foreach (var i in input.Where(item => item != -5)
                .OrderByDescending(item => item))
            {
                results.Add(i);
            }

            return results.ToArray();
        }

        public static int[] RetrieveDivisibleByTwo(int[] input)
        {
            var query = input.Where(item => item % 2 == 0).Select(item => item);

            return query.ToArray();
        }

        public static int[] RetrieveDivisibleByTwoSql(int[] input)
        {
            var query = from item in input
                where item % 2 == 0
                select item;

            return query.ToArray();
        }

        public static bool AreSquare(IEnumerable<int> numbers, IEnumerable<int> squares)
        {
            if (numbers.ToList().Count != squares.ToList().Count)
            {
                return false;
            }
                
            var nonSquares = numbers.Where((number, index) =>
                {
                    if (number * number != squares.ElementAt(index))
                    {
                        Console.WriteLine($"Found a number that doesn't have it's corresponding square {number}");
                        return true;
                    }

                    return false;
                })
                                        .Select(number => number)
                                        .ToList();

            return !nonSquares.Any();
        }

        public static bool AreSquareFast(IEnumerable<int> numbers, IEnumerable<int> squares)
        {
            if (numbers.ToList().Count != squares.ToList().Count)
            {
                return false;
            }

            var query = numbers.Where((number, index) => number * number != squares.ElementAt(index));

            foreach (int number in query)
            {
                Console.WriteLine($"Found a number that doesn't have it's corresponding square {number}");
                return false;
            }

            return true;
        }

        public static bool AreSquareYield(IEnumerable<int> numbers, IEnumerable<int> squares)
        {
            if (numbers.ToList().Count != squares.ToList().Count)
            {
                return false;
            }

            int index = 0;
            foreach (var number in numbers)
            {
                foreach (var i in ReturnNonSquare(number, squares.ElementAt(index)))
                {
                    Console.WriteLine($"Found a non-square result {i}");
                    return false;
                }

                index++;
            }

            return true;
        }

        public static IEnumerable<int> ReturnNonSquare(int number, int square)
        {
            if (number * number != square)
            {
                yield return square;
            }
        }
        

    }
}