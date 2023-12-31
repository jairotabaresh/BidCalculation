using BidCalculationExample.Services.Contracts;
using System;

namespace BidCalculationExample.Services
{
    /// <summary>
    /// Implementations of the methods used to calculate the values to be included in the final cost
    /// </summary>
    public class CalculationService : ICalculationService
    {
        /// <summary>
        /// Method that calculates the basic fee
        /// </summary>
        /// <param name="price"></param>
        /// <param name="vehicleType"></param>
        /// <returns></returns>
        public double CalculateBasicFee(decimal price, string vehicleType)
        {
            var baseFee = Math.Round(((double)price * Constants.basicFee), 2);

            if (vehicleType == Constants.Common)
            {
                if (baseFee < Constants.minCommonBasicFee)
                {
                    return Constants.minCommonBasicFee;
                }
                else if (baseFee > Constants.maxCommonBasicFee)
                {
                    return Constants.maxCommonBasicFee;
                }
            }
            else if (vehicleType == Constants.Luxury)
            {
                if (baseFee < Constants.minLuxuryBasicFee)
                {
                    return Constants.minLuxuryBasicFee;
                }
                else if (baseFee > Constants.maxLuxuryBasicFee)
                {
                    return Constants.maxLuxuryBasicFee;
                }
            }

            return baseFee;
        }

        /// <summary>
        /// Method that calculates the special fee
        /// </summary>
        /// <param name="price"></param>
        /// <param name="vehicleType"></param>
        /// <returns></returns>
        public double CalculateSpecialFee(decimal price, string vehicleType)
        {
            if (vehicleType == Constants.Common)
            {
                return Math.Round(((double)price * Constants.specialCommonFee), 2);
            }

            return Math.Round(((double)price * Constants.specialLuxuryFee), 2);
        }

        /// <summary>
        /// Method that calculates the association costs depending on the price and certain ranges
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public double CalculateAssociationCost(decimal price)
        {
            if ((double)price > Constants.associationCost1 && (double)price <= Constants.associationCost500)
            {
                return Constants.addedCost5;
            }
            else if ((double)price > Constants.associationCost500 && (double)price <= Constants.associationCost1000)
            {
                return Constants.addedCost10;
            }
            else if ((double)price > Constants.associationCost1000 && (double)price <= Constants.associationCost3000)
            {
                return Constants.addedCost15;
            }

            return Constants.addedCost20;
        }

        /// <summary>
        /// Method that calculates the total amount to be paid depending on the costs 
        /// initially calculated
        /// </summary>
        /// <param name="price"></param>
        /// <param name="basic"></param>
        /// <param name="special"></param>
        /// <param name="associationCost"></param>
        /// <returns></returns>
        public double CalculateTotalValue(decimal price, double basic, double special, double associationCost)
        {
            return (double)price + basic + special + associationCost + Constants.storage;
        }
    }
}
