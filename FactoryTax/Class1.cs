using ITax;
using System;
using TaxCalculation;

namespace FactoryTax
{
    public class CalculationFactory
    {
        public static ITaxInterface CreateTaxClass(int classNumber)
        {
            if (classNumber == 0)
                return new ClsTaxNewBrunwswick();
            
            if (classNumber == 1)
                return new ClsTaxNovaScotia();
            
            return null;
        }
    }
}
