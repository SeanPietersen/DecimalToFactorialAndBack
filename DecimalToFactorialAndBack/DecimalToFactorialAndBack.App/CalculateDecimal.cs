using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecimalToFactorialAndBack.App
{
    public class CalculateDecimal : ICalculateDecimal
    {
        
        public string DecimalToFactorialString(long nb)
        {
            var alphabeticalNumbers = new Dictionary<long, string>()
            {
                { 10 , "A" },
                { 11 , "B" },
                { 12 , "C" },
                { 13 , "D" },
                { 14 , "E" },
                { 15 , "F" },
                { 16 , "G" },
                { 17 , "H" },
                { 18 , "I" },
                { 19 , "J" },
                { 20 , "K" },
                { 21 , "L" },
                { 22 , "M" },
                { 23 , "N" },
                { 24 , "O" },
                { 25 , "P" },
                { 26 , "Q" },
                { 27 , "R" },
                { 28 , "S" },
                { 29 , "T" },
                { 30 , "U" },
                { 31 , "V" },
                { 32 , "W" },
                { 33 , "X" },
                { 34 , "Y" },
                { 35 , "Z" },
            };

            long divisor = 1;
            var listOfFactorials = new StringBuilder();

            while(nb != 0)
            {
                //int factorialNumber = (int)nb % divisor);
                long remainder;
                var quotient = Math.DivRem(nb, divisor, out remainder);
                if(remainder >= 10)
                {
                    listOfFactorials.Append(alphabeticalNumbers[remainder]);
                }
                else
                {
                    listOfFactorials.Append(remainder.ToString());
                }
                nb = quotient;
                divisor++;
            }
            return new string(listOfFactorials.ToString().Reverse().ToArray());
        }
    }
}
