namespace PrimeNumbers.BusinessLogic
{
    public interface IPrimeTableFactory
    {
        PrimeTable Create(int rank);
    }
}
