using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class CreditCard
    {
        // Returns true if the card number is valid.
        public static bool IsValid(string cardNumber)
        {
            // Get the sum result (step 4)
            int sumResult = SumOfDoubleEvenPlace(cardNumber) + SumOfOddPlace(cardNumber);
            if (sumResult % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Returns sum of even-place digits in card number (step 2).
        public static int SumOfDoubleEvenPlace(string cardNumber)
        {
            int sumEven = 0;
            var arrayEven = cardNumber.ToCharArray();
            for (int i = arrayEven.Length - 2; i >= 0; i = i - 2)
            {
                int doubleOfEvenDigit = Int32.Parse(arrayEven[i].ToString()) * 2;
                sumEven = sumEven + GetDigit(doubleOfEvenDigit);
            }
            return sumEven;
        }

        // Returns the sum of the two digits. This function is used in Step 2.
        public static int GetDigit(int number)
        {
            int sum = 0;
            if (number.ToString().Length == 2)
            {
                while (number > 0)
                {
                    int digit = number % 10;
                    sum = sum + digit;
                    number /= 10;
                }
                return sum;
            }
            else
                return number;
        }

        // Returns sum of odd-place digits in card number (Step 3).
        public static int SumOfOddPlace(string cardNumber)
        {
            int sumOdd = 0;
            var arrayOdd = cardNumber.ToCharArray();
            for (int i = arrayOdd.Length - 1; i >= 0; i = i - 2)
            {
                sumOdd = sumOdd + Int32.Parse(arrayOdd[i].ToString());
            }
            return sumOdd;
        }

        // Return true if substr is the prefix for card number.
        public static bool StartsWith(string cardNumber, string substr)
        {
            int len = substr.Length;
            if (cardNumber.Substring(0, len).Equals(substr))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
