using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers == null || numbers.Count() == 0 ? 0 : numbers.Min() +numbers.Max();
            //The instructor was having trouble getting the computer remember the numbers
            // while doing this the long way, remember to ask how these Min and Max methods are keeping track of the numbers
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers == null || numbers.Length == 0 ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            return numbers == null || numbers.Length == 0 ? 0 : numbers.Where(x => x % 2 == 0).Sum();
            //This might be a good example to explain yourself what's going on here:
            // Numbers == null is checking to see if it's a null, OR if the length equals 0, and then what to do if
            // it's not zero
            
            //The Where method here is taking a statement (internet says it's called a predicate)
            //"x" here is whatever number is put in, separated by what's called a "Lambda Operator" (=>)
            // "=>" acts as a separates the input and the expression
            //So it's checking if the remainder of the number is 0, and then using the built in Sum function if it is
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers != null && numbers.Count != 0 && numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number <= 0 ? 0 : number / 2;
            //Remember: you're dividing this by two because odds are every other number!
        }
    }
}
