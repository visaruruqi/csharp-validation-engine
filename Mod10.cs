using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Algorithms
{
    public class Mod10 : IValidationAlgorithm
    {
        public bool isMatch(AlgorithmType type)
        {
            return type == AlgorithmType.Mod10;
        }

        public bool isMatch(string validationAlgorithm)
        {
            return validationAlgorithm == "Mod10";
        }

        /*
         * For instance, the UPC-A barcode for a box of tissues is "036000241457". The last digit is the check digit "7", and if the other numbers are correct then the check digit calculation must produce 7.
         * 
         * Add the odd number digits: 0+6+0+2+1+5 = 14
         * Multiply the result by 3: 14 × 3 = 42
         * Add the even number digits: 3+0+0+4+4 = 11
         * Add the two results together: 42 + 11 = 53
         * To calculate the check digit, take the remainder of (53 / 10), which is also known as (53 modulo 10), and subtract from 10. Therefore, the check digit value is 7.
         */
        public bool isValid(string barcode)
        {
            bool valid = false;

            try
            {
                int lastDigit = int.Parse(barcode.Last().ToString());
                barcode = barcode.Substring(0, barcode.Length - 1);

                int odds = 0;
                int evens = 0;

                for (int i = 1; i <= barcode.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        evens = evens + int.Parse(barcode[i-1].ToString());
                    }
                    else
                    {
                        odds = odds + int.Parse(barcode[i-1].ToString());
                    }
                }

                odds = odds * 3;

                int sum = odds + evens;

                int checkDigit = 10 - (sum % 10);

                if (checkDigit == 10)
                {
                    checkDigit = 0;
                }

                if (checkDigit == lastDigit)
                {
                    valid = true;
                }
            }
            catch
            {
                valid = false;
            }

            return valid;
        }


      
    }
}
