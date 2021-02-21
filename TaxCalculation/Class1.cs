using ITax;

namespace TaxCalculation
{
    public class ClsTaxNewBrunwswick : ITaxInterface
    {
        public double Amount { get; set; }

        public double CalculateTax()
        {
            // 15% of tax
            return (Amount * 0.11);
        }
    }

    public class ClsTaxNovaScotia : ITaxInterface
    {
        public double Amount { get; set; }

        public double CalculateTax()
        {
            // 18% of tax
            return (Amount * 0.18);
        }
    }

}
