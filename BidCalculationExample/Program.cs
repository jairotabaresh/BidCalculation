using BidCalculationExample.Services;
using BidCalculationExample.Services.Contracts;
using System;
using System.Windows.Forms;

namespace BidCalculationExample
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application
        /// The idea was to use Windows Forms to be able to graphically test the application, 
        /// I did it this way because it is simple and I used .Net Framework instead of 
        /// .Net Core to include simple single tests
        /// </summary>
        [STAThread]
        static void Main()
        {
            ICalculationService _calculationService = new CalculationService();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BidCalculationForm(_calculationService));
        }
    }
}
