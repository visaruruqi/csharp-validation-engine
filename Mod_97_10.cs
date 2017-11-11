using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Algorithms
{
    public class Mod_97_10 : IValidationAlgorithm
    {
        public bool isMatch(AlgorithmType type)
        {
            return type == AlgorithmType.Mod_97_10;
        }

        public bool isMatch(string validationAlgorithm)
        {
            return validationAlgorithm == "BankAccountNumber";
        }

        /// <summary>
        /// For the string 794 the procedure is:
        /// step 1: append two zeroes to occupy the check character positions: 79400;
        /// step 2: divide by 97, to give the quotient 818 and the integer remainder 54;
        /// step 3: determine the check character value as (97 + 1) - 54 = 44 and append it to the original string to give 79444.
        /// </summary>
        /// <param name="barcode">Usually Bank account number is enetered</param>
        /// <returns>Returns true if the bank account number is valid otherwise false</returns>
        public bool isValid(string barcode)
        {

            var valid = false;

            try
            {
                if (barcode.Length != 16)
                    throw new ArgumentException("Bank Account number cannot be greater or less then 16 characters");

                var origin = barcode.Substring(0, 14);
                var checkDigits = barcode.Substring(14, 2);

                var originNum = long.Parse(origin+"00");
                var checkDigitsNum = long.Parse(checkDigits);

                var result = (97 + 1) - (originNum % 97);

                if (result == checkDigitsNum)
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
