using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace DecimalToFactorialAndBack.App
{
    public class CalculateFactorialRepresentation : ICalculateFactorialRepresentation
    {

        public long FactorialStringToDecimal(string str)
        {
            var alphabeticalNumbers = new Dictionary< string , long >()
            {
                { "A", 10 },
                { "B", 11 },
                { "C", 12 },
                { "D", 13 },
                { "E", 14 },
                { "F", 15 },
                { "G", 16 },
                { "H", 17 },
                { "I", 18 },
                { "J", 19 },
                { "K", 20 },
                { "L", 21 },
                { "M", 22 },
                { "N", 23 },
                { "O", 24 },
                { "P", 25 },
                { "Q", 26 },
                { "R", 27 },
                { "S", 28 },
                { "T", 29 },
                { "U", 30 },
                { "V", 31 },
                { "W", 32 },
                { "X", 33 },
                { "Y", 34 },
                { "Z", 35 },
            };
            
            long value = 0;
            char[] numbers = str.ToCharArray();
            int factorialMultiple = numbers.Count() - 1;

            foreach (var number in numbers)
            {
                long factorialValue = 1;
                for (int i = factorialMultiple; i > 0;  i--)
                {
                    factorialValue *= i;
                    //factorialValue = (int)BigInteger.Multiply(factorialValue, i);
                }
                if (!char.IsDigit(number))
                {
                    value += (int) alphabeticalNumbers[number.ToString()] * factorialValue;
                }
                else
                {
                    long valueToAdd = (long)char.GetNumericValue(number) * factorialValue;
                    value += valueToAdd;
                }
                factorialMultiple--;
            }
            return value;
        }
    }
}