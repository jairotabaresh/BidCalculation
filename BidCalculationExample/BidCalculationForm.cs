using BidCalculationExample.Services.Contracts;
using System;
using System.Windows.Forms;

namespace BidCalculationExample
{
    /// <summary>
    /// Form with the fields used to display the information
    /// </summary>
    public partial class BidCalculationForm : Form
    {
        /// <summary>
        /// Dependency injection to be able to use calculation methods
        /// </summary>
        private readonly ICalculationService _calculationService;
        public BidCalculationForm(ICalculationService calculationService)
        {
            _calculationService = calculationService;
            InitializeComponent();
        }

        /// <summary>
        /// Simple validation to avoid null or wrong values and method call to 
        /// assign the result values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cbVehicleType.Text == "")
            {
                MessageBox.Show("Missing Vehicle Type");
            }
            else if (nudVehicleBasePrice.Value <= 0)
            {
                MessageBox.Show("Wrong Vehicle Price");
            }
            else
            {
                pnlResult.Visible = true;
                AssignValues();
            }
        }

        /// <summary>
        /// Method that invokes the class that does the calculations and assigns the values 
        /// to the form, this last part is better handled elsewhere to maintain single 
        /// responsibility, but I did it here to be able to use the form components directly
        /// </summary>
        private void AssignValues()
        {
            txtPrice.Text = nudVehicleBasePrice.Value.ToString();
            txtType.Text = cbVehicleType.Text;
            var basicFee = _calculationService.CalculateBasicFee(nudVehicleBasePrice.Value, cbVehicleType.Text);
            txtBasic.Text = basicFee.ToString();
            var specialFee = _calculationService.CalculateSpecialFee(nudVehicleBasePrice.Value, cbVehicleType.Text);
            txtSpecial.Text = specialFee.ToString();
            var associationCost = _calculationService.CalculateAssociationCost(nudVehicleBasePrice.Value);
            txtaddedCost.Text = associationCost.ToString();
            txtStorage.Text = Constants.storage.ToString();
            var totalCost = _calculationService.CalculateTotalValue(nudVehicleBasePrice.Value, basicFee, specialFee, associationCost);
            txttotalValue.Text = totalCost.ToString();
        }
    }
}
