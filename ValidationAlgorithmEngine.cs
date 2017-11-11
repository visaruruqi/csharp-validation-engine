using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Algorithms
{
    public class ValidationAlgorithmEngine : IValidationAlgorithmEngine
    {
        private readonly List<IValidationAlgorithm> _algorithms;

        public ValidationAlgorithmEngine()
        {
            _algorithms = new List<IValidationAlgorithm>();
            _algorithms.Add(new FiscalNo());
            _algorithms.Add(new Mod_97_10());
            _algorithms.Add(new Mod10());
        }

        public bool isValid(string barcode, AlgorithmType type)
        {
            return _algorithms.First(r => r.isMatch(type)).isValid(barcode.Trim());
        }

        public bool isValid(string barcode, string validationAlgorithm)
        {
            return _algorithms.First(r => r.isMatch(validationAlgorithm)).isValid(barcode.Trim());
        }
       
    }
}
