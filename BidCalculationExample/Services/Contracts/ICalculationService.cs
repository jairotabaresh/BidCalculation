namespace BidCalculationExample.Services.Contracts
{
    /// <summary>
    /// Signatures of the methods used to calculate the values to be included in the final cost
    /// </summary>
    public interface ICalculationService
    {
        double CalculateBasicFee(decimal price, string vehicleType);
        double CalculateSpecialFee(decimal price, string vehicleType);
        double CalculateAssociationCost(decimal price);
        double CalculateTotalValue(decimal price, double basic, double special, double associationCost);
    }
}
