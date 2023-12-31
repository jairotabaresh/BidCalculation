using BidCalculationExample.Services;
using BidCalculationExample.Services.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    /// <summary>
    /// Some unit tests to test the cost calculation functionality covering at 
    /// least one scenario for each cost
    /// </summary>
    [TestClass]
    public class CalculationServiceTest
    {
        public  ICalculationService _calculationService;

        public CalculationServiceTest()
        {
            _calculationService = new CalculationService();
        }

        [TestMethod]
        public void Calculate_Basic_Fee_Ok()
        {
            //Arrange
            double expected = 38.9;
            decimal price = 389;
            string type = "Common";
            
            //Act
            var obtained = _calculationService.CalculateBasicFee(price, type);

            //Assert
            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void Calculate_Basic_Fee_Fails()
        {
            //Arrange
            double expected = 76;
            decimal price = 389;
            string type = "Common";

            //Act
            var obtained = _calculationService.CalculateBasicFee(price, type);

            //Assert
            Assert.AreNotEqual(expected, obtained);
        }

        [TestMethod]
        public void Calculate_Special_Fee_Ok()
        {
            //Arrange
            double expected = 72;
            decimal price = 1800;
            string type = "Luxury";
            
            //Act
            var obtained = _calculationService.CalculateSpecialFee(price, type);

            //Assert
            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void Calculate_Special_Fee_Fails()
        {
            //Arrange
            double expected = 23;
            decimal price = 1800;
            string type = "Common";

            //Act
            var obtained = _calculationService.CalculateSpecialFee(price, type);

            //Assert
            Assert.AreNotEqual(expected, obtained);
        }

        [TestMethod]
        public void Calculate_Association_Cost_Ok()
        {
            //Arrange
            double expected = 20;
            decimal price = 3500;

            //Act
            var obtained = _calculationService.CalculateAssociationCost(price);

            //Assert
            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void Calculate_Association_Cost_Fails()
        {
            //Arrange
            double expected = 5;
            decimal price = 3500;

            //Act
            var obtained = _calculationService.CalculateAssociationCost(price);

            //Assert
            Assert.AreNotEqual(expected, obtained);
        }

        [TestMethod]
        public void Calculate_Total_Value_Ok()
        {
            //Arrange
            double expected = 1287;
            decimal price = 1100;
            double basic = 50;
            double special = 22;
            double associationCost = 15;

            //Act
            var oibtained = _calculationService.CalculateTotalValue(price, basic, special, associationCost);

            //Assert
            Assert.AreEqual(expected, oibtained);
        }


        [TestMethod]
        public void Calculate_Total_Value_Fails()
        {
            //Arrange
            double expected = 1287;
            decimal price = 1100;
            double basic = 50;
            double special = 22;
            double associationCost = 66;

            //Act
            var oibtained = _calculationService.CalculateTotalValue(price, basic, special, associationCost);

            //Assert
            Assert.AreNotEqual(expected, oibtained);
        }
    }
}
