using System;
using System.Globalization;
using System.Windows.Forms;

namespace EoSNI
{
    public partial class MainForm : Form
    {
        public string CurrencySymbol { get; set; } = "";
        public MainForm()
        {
            InitializeComponent();
            NumberFormatInfo nfi = CultureInfo.CurrentCulture.NumberFormat;
            CurrencySymbol = nfi.CurrencySymbol;
        }

        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            double cost = CalculateCost();
            double vat = cost / 1.2 * (double)numVAT.Value / 100;
            new ShippingQuoteForm($"Number of packages: {numNumberOfPackages.Value}\nTotal weight: {CalculateWeight()}kg\nBase price: {numBaseCost.Value.ToString("C")}\nCost/kg; {numCostPerKg.Value.ToString("C")}\nVAT: {vat.ToString("C")} (%{numVAT.Value})\n\nTOTAL: {cost.ToString("C")}").ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtPackageType.Clear();
            numWeightPerPackage.ResetText();
            numNumberOfPackages.ResetText();
            numBaseCost.ResetText();
            lblTotalWeight.Text = "Total Weight:";
            lblTotalCost.Text = "Total Cost:";
            dtpDispatchDate.Value = DateTime.Now;
            dtpTargetDeliveryDate.Value = DateTime.Now;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numWeightPerPackage_ValueChanged(object sender, EventArgs e)
        {
            numTotalWeight.Text = Convert.ToString(CalculateWeight());
            numTotalCost.Text = Convert.ToString(CalculateCost());
        }

        private void numNumberOfPackages_ValueChanged(object sender, EventArgs e)
        {
            numTotalWeight.Text = Convert.ToString(CalculateWeight());
            numTotalCost.Text = Convert.ToString(CalculateCost());
        }

        public double CalculateWeight()
        {
            double totalWeight = (double)numWeightPerPackage.Value * (double)numNumberOfPackages.Value;
            return totalWeight;
        }

        public double CalculateCost()
        {
            double price = ((double)numBaseCost.Value + (double)numCostPerKg.Value * (double)numTotalWeight.Value);
            double totalCost = price + price * (double)numVAT.Value / 100;
            return totalCost;
        }

        private void numBaseCost_ValueChanged(object sender, EventArgs e)
        {
            numTotalCost.Text = Convert.ToString(CalculateCost());
        }

        private void numCostPerKg_ValueChanged(object sender, EventArgs e)
        {
            numTotalCost.Text = Convert.ToString(CalculateCost());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numTotalCost.Text = Convert.ToString(CalculateCost());
        }
    }
}
