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
    public partial class ExpensesForm : Form
    {
        public ExpensesForm()
        {
            InitializeComponent();
        }

        private void LoadExpenses()
        {
            expensesListBox.Items.Clear();

            foreach (string line in File.ReadAllLines("expenses.txt"))
            {
                string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length >= 2 && decimal.TryParse(parts[1], out decimal amount))
                {
                    expensesListBox.Items.Add($"{parts[0]} - {amount:C}");
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].Show();
            this.Close();
        }

        private void expensesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExpensesForm_Load(object sender, EventArgs e)
        {
            LoadExpenses();
        }
    }
}
