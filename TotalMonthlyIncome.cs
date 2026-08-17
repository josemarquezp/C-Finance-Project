using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Income_and_Taxes
{
    public partial class TotalMonthlyIncome : Form
    {
        public TotalMonthlyIncome()
        {
            InitializeComponent();
        }

        private decimal LoadIncome()
        {
            decimal total = 0m;
            incomeListBox.Items.Clear();

            foreach (string line in File.ReadAllLines("income.txt"))
            {
                string[] parts = line.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length >= 2 && decimal.TryParse(parts[1], out decimal amount))
                {
                    incomeListBox.Items.Add($"{parts[0]} - {amount:C}");
                    total += amount;

                }
            }
            return total;
        }

        private decimal LoadAfterTaxIncome()
        {
            decimal total = 0m;

            if (!File.Exists("incomeAfterTaxes.txt")) return 0m;

            foreach (string line in File.ReadAllLines("incomeAfterTaxes.txt"))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split('\t');

                if (parts.Length >= 2 && decimal.TryParse(parts[1], out decimal amount))
                {
                    total += amount;
                }
            }

            return total;
        }


        private void TotalMonthlyIncome_Load(object sender, EventArgs e)
        {
            decimal totalIncome = LoadIncome();
            totalIncomeTextBox.Text = totalIncome.ToString("C");
            decimal totalAfterTax = LoadAfterTaxIncome();
            afterTaxIncomeTextBox.Text = totalAfterTax.ToString("C");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
