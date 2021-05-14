using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int evens = 0;
            int odds = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int num = numbers[i];
                if (num % 2 == 0)
                {
                    evens += num;
                }
                else
                {
                    odds += num;
                }
            }
            return evens - odds;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string long1 = (str1.Length < str2.Length) ? str1 : str2;
            string long2 = (str3.Length < str4.Length) ? str3 : str4;
            return (long1.Length > long2.Length) ? long2.Length : long1.Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int num1 = (number1 < number2) ? number1 : number2;
            int num2 = (number3 < number4) ? number3 : number4;
            return (num1 < num2) ? num1 : num2;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {

            return (sideLength1 > 0 && sideLength2 > 0 && sideLength3 > 1 && sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            if (input == null)
            {
                return false;
            }
            if (input =="")
            {
                return false;
            }
            return input.Any(char.IsLetter) || input.Contains("*") || input.Contains("#")? false: true;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var count = 0;
            foreach (var ob in objs)
            {
                if (ob == null)
                {
                    count++;
                }
            }
            return (count > objs.Length / 2);
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length < 1)
            {
                return 0;
            }
            double total = 0;
            int count = 0;
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    total += num;
                    count++;
                    
                }

            }
            if (count == 0)
            {
                return 0;
            }
            return total/count;

                
        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            int total = 1;
                while (number != 1)
                {
                    total = total * number;
                    number--;
                }

            return total;
   
        }
    }
}
