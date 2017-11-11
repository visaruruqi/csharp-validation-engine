using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Algorithms
{
    public interface IValidationAlgorithm
    {
        bool isMatch(AlgorithmType type);

        bool isValid(string pattern);

        bool isMatch(string validation);
    }
}
