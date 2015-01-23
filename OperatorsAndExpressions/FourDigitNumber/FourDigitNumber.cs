namespace FourDigitNumber
{
    using System;
    using System.Linq;
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a four-digit number: ");
            int[] digits = Console.ReadLine()
                .Trim()
                .ToCharArray()
                .Select(x => Int32.Parse(x.ToString()))
                .ToArray();

            if (digits.Length != 4)
            {
                Console.WriteLine("The number must have exactly 4 digits.");
                return;
            }
            if (digits[0] == 0)
            {
                Console.WriteLine("The number cannot start with 0.");
                return;
            }
            Console.Clear();


            Console.WriteLine(@"
{4}

Sum of digits:      {0}
Reversed digits:    {1}
Last digit-first:   {2}
Swap 2nd and 3rd:   {3}
"
                .Trim(),
                SumDigits(digits), ReverseDigits(digits), LastDigitFirst(digits),
                SwapSecondAndThird(digits), string.Join("", digits));
        }

        static int SumDigits(int[] digits)
        {
            int sum = 0;
            foreach (var digit in digits)
            {
                sum += digit;
            }
            return sum;
        }

        static string ReverseDigits(int[] digits)
        {
            string reversedDigits = string.Join("", digits.Reverse());
            return reversedDigits;
        }

        static string LastDigitFirst(int[] digits)
        {
            string lastDigitFirst = "" + digits[digits.Length - 1];
            for (int i = 0; i < digits.Length - 1; i++)
            {
                lastDigitFirst += digits[i];
            }

            return lastDigitFirst;
        }

        static string SwapSecondAndThird(int[] digits)
        {
            return digits[0].ToString() + digits[2] + digits[1] + digits[3];
        }
    }
}
