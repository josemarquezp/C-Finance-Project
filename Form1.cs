/* Jose Marquez Final Project
    4/18/2026
    This program lets a user enter income and see taxes and remaining money.
    It also loads expenses from a file and saves the data for later.
*/

using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Income_and_Taxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Saves the income source and amount into a text file
        private void PushIncome(string incomeSource, decimal income)
        {
            try
            {
                using (StreamWriter inputFile = File.AppendText("income.txt"))
                {
                    inputFile.WriteLine(incomeSource + "\t" + income);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing income: {ex.Message}");
            }
        }

        // Saves income AFTER taxes
        private void IncomeAfterTaxes(string incomeSource, decimal incomeAfterTax)
        {
            try
            {
                using (StreamWriter inputFile = File.AppendText("incomeAfterTaxes.txt"))
                {
                    inputFile.WriteLine(incomeSource + "\t" + incomeAfterTax);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing after-tax income: {ex.Message}");
            }
        }

        private List<decimal> expenses = new List<decimal>();

        // Loads expenses and calculates total
        private decimal LoadExpenses()
        {
            decimal totalExpenses = 0m;
            expenses.Clear();

            if (File.Exists("expenses.txt"))
            {
                foreach (string line in File.ReadAllLines("expenses.txt"))
                {
                    string[] parts = line.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length >= 2 && decimal.TryParse(parts[1], out decimal amount))
                    {
                        expenses.Add(amount);
                        totalExpenses += amount;
                    }
                }
            }

            expensestTextBox.Text = totalExpenses.ToString("C");
            return totalExpenses;
        }

        //  Total AFTER TAX income
        private decimal LoadTotalAfterTaxIncome()
        {
            decimal total = 0m;

            if (File.Exists("incomeAfterTaxes.txt"))
            {
                foreach (string line in File.ReadAllLines("incomeAfterTaxes.txt"))
                {
                    string[] parts = line.Split('\t');

                    if (parts.Length >= 2 && decimal.TryParse(parts[1], out decimal amount))
                    {
                        total += amount;
                    }
                }
            }

            return total;
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            decimal taxRate = 0;

            if (taxRadio1.Checked) taxRate = 0.10m;
            else if (taxRadio2.Checked) taxRate = 0.12m;
            else if (taxRadio3.Checked) taxRate = 0.22m;
            else if (taxRadio4.Checked) taxRate = 0.24m;
            else if (taxRadio5.Checked) taxRate = 0.32m;
            else if (taxRadio6.Checked) taxRate = 0.35m;
            else if (taxRadio7.Checked) taxRate = 0.37m;
            else
            {
                MessageBox.Show("You need to select a tax bracket");
                return;
            }

            string incomeSource = incomeSourceTextBox.Text;

            if (incomeSource == "")
            {
                MessageBox.Show("Please enter an income source.");
                return;
            }

            if (!decimal.TryParse(incomeAmountTextBox.Text, out decimal income))
            {
                MessageBox.Show("Enter a valid number.");
                return;
            }

            decimal taxAmount = income * taxRate;
            decimal incomeAfterTax = income - taxAmount;

            decimal totalExpenses = LoadExpenses();

            // UI display
            taxAmountTextBox.Text = taxAmount.ToString("C");
            incomeAfterTaxTextBox.Text = incomeAfterTax.ToString("C");

            // Save
            IncomeAfterTaxes(incomeSource, incomeAfterTax);

            IncomeEntry entry = new IncomeEntry(incomeSource, income);
            PushIncome(entry.Source, entry.Amount);



            // use AFTER TAX total

            decimal totalAfterTax = LoadTotalAfterTaxIncome();

            decimal balance = totalAfterTax - totalExpenses;
            balanceTextBox.Text = balance.ToString("C");


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox &&
                    textBox != balanceTextBox &&
                    textBox != expensestTextBox)
                {
                    textBox.Text = "";
                }
            }

            foreach (Control control in this.Controls)
            {
                if (control is GroupBox group)
                {
                    foreach (Control rb in group.Controls)
                    {
                        if (rb is RadioButton radio)
                        {
                            radio.Checked = false;
                        }
                    }
                }
            }

            incomeSourceTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            decimal totalExpenses = LoadExpenses();
            decimal totalAfterTax = LoadTotalAfterTaxIncome();

            decimal balance = totalAfterTax - totalExpenses;
            balanceTextBox.Text = balance.ToString("C");
        }

        private void expensesButton_Click(object sender, EventArgs e)
        {
            ExpensesForm form = new ExpensesForm();
            form.ShowDialog();
        }

        private void incomeButton_Click(object sender, EventArgs e)
        {
            TotalMonthlyIncome form = new TotalMonthlyIncome();
            form.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}