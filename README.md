# csharp-validation-engine
Simple validation engine for C-Sharp, encapsulator for different algorithms

usage example

```csharp
IValidationAlgorithmEngine engine = new ValidationAlgorithmEngine();

//match pattern against a specific algorithm defined in the enum AlgorithmType
Assert.IsTrue(engine.isValid("000017", AlgorithmType.Mod10));
Assert.IsFalse(engine.isValid("000018", AlgorithmType.Mod10));

Assert.IsTrue(engine.isValid("1110195681000188", AlgorithmType.Mod_97_10));
Assert.IsFalse(engine.isValid("2020000090180955", AlgorithmType.Mod_97_10));

```
