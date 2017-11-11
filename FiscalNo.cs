using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Algorithms
{
    public class FiscalNo : IValidationAlgorithm
    {

        public bool isMatch(string validation)
        {
            return validation == "FiscalNo";
        }

        public bool isMatch(AlgorithmType type)
        {
            return type == AlgorithmType.FiskalNr;
        }

        public bool isValid(string fiscalno)
        {
            long temp;

            if (fiscalno.Length != 9)
                return false;

            if (!long.TryParse(fiscalno, out temp))
                return false;


              //algorithm implementation goes here
                
                //return true for valid fiscal number and false for not valid
                return true;
        }


       
    }
}
