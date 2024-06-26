﻿using System;
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
            numTotalWeight.Text = Convert.ToString(CalculateWeight());
            numTotalCost.Text = Convert.ToString(CalculateCost());
        }

        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            double cost = CalculateCost();
            double vat = cost / 1.2 * (double)numVAT.Value / 100;
            string[] quoteStrings = {$"Customer name: {txtCustomerName.Text}\n",
                $"Address: {txtAddress.Text}\n",
                $"Post code: {txtPostCode.Text}\n",
                $"Phone number: {txtPhoneNumber.Text}\n",
                $"Package type: {txtPackageType.Text}\n",
                $"Number of packages: {numNumberOfPackages.Value}\n",
                $"Total weight: {CalculateWeight()}kg\n",
                $"Delivery type: {cmbDeliveryType.Text}\n",
                $"Dispatch date: {dtpDispatchDate.Value}\n",
                $"Target delivery date: {dtpTargetDeliveryDate.Value}\n",
                $"Base price: {numBaseCost.Value.ToString("C")}\n",
                $"Cost/kg: {numCostPerKg.Value.ToString("C")}\n",
                $"Total: {(cost - vat).ToString("C")}\n",
                $"VAT: {vat.ToString("C")} (%{numVAT.Value})\n\n",
                $"TOTAL: {cost.ToString("C")}"};

            int maxLength = 74;

            for (int i = 0; i < quoteStrings.Length; i++)
            {
                if (quoteStrings[i].Replace("\n", "").Length > maxLength) maxLength = quoteStrings[i].Length;
            }

            for (int i = 0; i < quoteStrings.Length; i++)
            {
                string[] strings = quoteStrings[i].Split(": ");
                strings[0] += ":";
                strings[0] = strings[0].PadRight(maxLength - strings[1].Replace("\n", "").Length);
                strings[0] += strings[1];
                quoteStrings[i] = strings[0];
            }

            string quote = "";

            for (int i = 0; i < quoteStrings.Length; i++)
            {
                quote += quoteStrings[i];
            }

            new ShippingQuoteForm(quote).ShowDialog();
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
            btnResetBaseCost.Visible = true;
        }

        private void numCostPerKg_ValueChanged(object sender, EventArgs e)
        {
            numTotalCost.Text = Convert.ToString(CalculateCost());
            btnResetCostPerKg.Visible = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numTotalCost.Text = Convert.ToString(CalculateCost());
            btnResetVAT.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dtpDispatchDate.Value = DateTime.Now.AddDays(1);
            dtpTargetDeliveryDate.Value = DateTime.Now.AddDays(4);
            cmbDeliveryType.SelectedIndex = 0;
        }

        private void btnResetVAT_Click(object sender, EventArgs e)
        {
            numVAT.Value = 20;
            btnResetVAT.Visible = false;
        }

        private void btnResetBaseCost_Click(object sender, EventArgs e)
        {
            numBaseCost.Value = 1;
            btnResetBaseCost.Visible = false;
        }

        private void btnResetCostPerKg_Click(object sender, EventArgs e)
        {
            numCostPerKg.Value = 1;
            btnResetCostPerKg.Visible = false;
        }
    }
}
