using System;

namespace Task1_7_Numbers_to_Words
{
    class Numbers_to_Words
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            foreach (int number in arr)
            {
                if (number < -999)
                {
                    Console.WriteLine("too small");
                }
                else if (number > 999)
                {
                    Console.WriteLine("too large");
                }
                else if (number > -100 && number < 100)
                {

                }
                else
                {
                    Console.WriteLine(Letterize(number));
                }
            }
        }

        static string Letterize(int number)
        {
            string minus = number < 0 ? "minus " : "";

            string hundreds = string.Empty;
            
            int hund = Math.Abs(number / 100);

            switch (hund)
            {
                case 1: hundreds = "one-hundred"; break;
                case 2: hundreds = "two-hundred"; break;
                case 3: hundreds = "three-hundred"; break;
                case 4: hundreds = "four-hundred"; break;
                case 5: hundreds = "five-hundred"; break;
                case 6: hundreds = "six-hundred"; break;
                case 7: hundreds = "seven-hundred"; break;
                case 8: hundreds = "eight-hundred"; break;
                case 9: hundreds = "nine-hundred"; break;
                default:
                    break;
            }

            if (number % 100 == 0)
            {
                return minus + hundreds;
            }

            number = Math.Abs(number % 100);

            int d1, d2;
            string word1 = string.Empty;
            string word2 = string.Empty;
            string name = string.Empty;

            d1 = number / 10;
            d2 = number % 10;

            if (d1 == 1)
            {
                switch (d2)
                {

                    case 1: name = minus + hundreds + " and " + "eleven"; break;
                    case 2: name = minus + hundreds + " and " + "twelve"; break;
                    case 3: name = minus + hundreds + " and " + "thirteen"; break;
                    case 4: name = minus + hundreds + " and " + "fourteen"; break;
                    case 5: name = minus + hundreds + " and " + "fifteen"; break;
                    case 6: name = minus + hundreds + " and " + "sixteen"; break;
                    case 7: name = minus + hundreds + " and " + "seventeen"; break;
                    case 8: name = minus + hundreds + " and " + "eighteen"; break;
                    case 9: name = minus + hundreds + " and " + "nineteen"; break;
                    default: name = minus + hundreds + " and " + "ten"; break;
                }
            }
            else if (d1 == 0)
            {
                switch (d2)
                {
                    case 1: name = minus + hundreds + " and " + "one"; break;
                    case 2: name = minus + hundreds + " and " + "two"; break;
                    case 3: name = minus + hundreds + " and " + "three"; break;
                    case 4: name = minus + hundreds + " and " + "four"; break;
                    case 5: name = minus + hundreds + " and " + "five"; break;
                    case 6: name = minus + hundreds + " and " + "six"; break;
                    case 7: name = minus + hundreds + " and " + "seven"; break;
                    case 8: name = minus + hundreds + " and " + "eight"; break;
                    case 9: name = minus + hundreds + " and " + "nine"; break;
                    default: break;
                }
            }
            else
            {
                switch (d1)
                {
                    case 2: word1 = "twenty"; break;
                    case 3: word1 = "thirty"; break;
                    case 4: word1 = "forty"; break;
                    case 5: word1 = "fifty"; break;
                    case 6: word1 = "sixty"; break;
                    case 7: word1 = "seventy"; break;
                    case 8: word1 = "eighty"; break;
                    case 9: word1 = "ninety"; break;
                    default: word1 = ""; break;
                }
                switch (d2)
                {
                    case 1: word2 = "one"; break;
                    case 2: word2 = "two"; break;
                    case 3: word2 = "three"; break;
                    case 4: word2 = "four"; break;
                    case 5: word2 = "five"; break;
                    case 6: word2 = "six"; break;
                    case 7: word2 = "seven"; break;
                    case 8: word2 = "eight"; break;
                    case 9: word2 = "nine"; break;
                    default: word2 = ""; break;
                }
                if (word1 == "")
                {
                    name = minus + hundreds + " and " + word2;
                }
                else if (word2 == "")
                {
                    name = minus + hundreds + " and " + word1;
                }
                else
                {
                    name = minus + hundreds + " and " + word1 + " " + word2;
                }
            }

            return name;
        }
    }
}
