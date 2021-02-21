using FactoryTax;
using ITax;
using System;
using System.Windows.Forms;

namespace TaxCalculatorInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Helpers
            LoadDropDownItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ITaxInterface taxSelected = CalculationFactory.CreateTaxClass(comboBox1.SelectedIndex);
            taxSelected.Amount = decimal.ToDouble(numericUpDown1.Value);
            DialogResult res = MessageBox.Show(
                "This is the tax for your region:\n"+taxSelected.CalculateTax().ToString(), 
                "Confirmation", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Information);
        }

        private void LoadDropDownItems()
        {
            comboBox1.Items.Add("New Brunswick");
            comboBox1.Items.Add("Nova Scotia");
            comboBox1.SelectedIndex = 0;
        }
    }
}
