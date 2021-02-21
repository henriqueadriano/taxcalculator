namespace ITax
{
    public interface ITaxInterface
    {
        double Amount { set; get; }
        double CalculateTax();
    }
}
