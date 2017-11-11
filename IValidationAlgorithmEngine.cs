using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Algorithms
{
    public interface IValidationAlgorithmEngine
    {
        bool isValid(string pattern, AlgorithmType type);

        bool isValid(string pattern, string validationAlgorithm);

    }
}
