using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
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
            if (numbers == null)
            {
                return 0;
            }
            double sum = 0;
            foreach (double num in numbers)
            {
                    sum = numbers.Min() + numbers.Max();
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
                var total = 0;
                foreach (int num in numbers)
                {
                    total += num;
                }
                return total;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var sum = 0;
            foreach (var item in numbers)
            {
                sum = (item % 2 == 0) ? sum + item : sum;
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return (sum % 2 != 0);

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int count = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
