using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SprayingDosageCalculator
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                decimal agentOut = Decimal.Parse(agentInputTextBox.Text.Replace('.', ',')) * Decimal.Parse(hectaresTextBox.Text.Replace('.', ','));
                agentOutputTextbox.Text = agentOut.ToString();

                decimal water = Decimal.Parse(sprayRateTextBox.Text.Replace('.', ',')) * Decimal.Parse(hectaresTextBox.Text.Replace('.', ',')) - agentOut;
                waterTextbox.Text = water.ToString();
            }
        }

        private void agentInputTextBox_Validating(object sender, CancelEventArgs e)
        {
            decimal agent;
            if (string.IsNullOrWhiteSpace(agentInputTextBox.Text))
            {
                e.Cancel = true;
                agentInputTextBox.Focus();
                errorProviderApp.SetError(agentInputTextBox, "This should not be left blank");
            }else if(!decimal.TryParse(agentInputTextBox.Text, out agent))
            {
                e.Cancel = true;
                agentInputTextBox.Focus();
                errorProviderApp.SetError(agentInputTextBox, "This should be a number");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(agentInputTextBox, "");
            }
        }

        private void hectaresTextBox_Validating(object sender, CancelEventArgs e)
        {
            decimal hectares;
            if (string.IsNullOrWhiteSpace(hectaresTextBox.Text))
            {
                e.Cancel = true;
                hectaresTextBox.Focus();
                errorProviderApp.SetError(hectaresTextBox, "This should not be left blank");
            }
            else if (!decimal.TryParse(hectaresTextBox.Text, out hectares))
            {
                e.Cancel = true;
                hectaresTextBox.Focus();
                errorProviderApp.SetError(hectaresTextBox, "This should be a number");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(hectaresTextBox, "");
            }
        }

        private void sprayRateTextBox_Validating(object sender, CancelEventArgs e)
        {
            decimal sprayRate;
            if (string.IsNullOrWhiteSpace(sprayRateTextBox.Text))
            {
                e.Cancel = true;
                sprayRateTextBox.Focus();
                errorProviderApp.SetError(sprayRateTextBox, "This should not be left blank");
            }
            else if (!decimal.TryParse(sprayRateTextBox.Text, out sprayRate))
            {
                e.Cancel = true;
                sprayRateTextBox.Focus();
                errorProviderApp.SetError(sprayRateTextBox, "This should be a number");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(sprayRateTextBox, "");
            }

        }
    }
}
