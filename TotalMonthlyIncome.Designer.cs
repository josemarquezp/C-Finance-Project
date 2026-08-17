namespace Income_and_Taxes
{
    partial class TotalMonthlyIncome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backButton = new Button();
            totalIncomeLabel = new Label();
            incomeListBox = new ListBox();
            totalIncomeTextBox = new TextBox();
            afterTaxIncomeTextBox = new TextBox();
            afterTaxIncomeLabel = new Label();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(191, 320);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 5;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // totalIncomeLabel
            // 
            totalIncomeLabel.AutoSize = true;
            totalIncomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalIncomeLabel.Location = new Point(105, 25);
            totalIncomeLabel.Name = "totalIncomeLabel";
            totalIncomeLabel.Size = new Size(113, 21);
            totalIncomeLabel.TabIndex = 4;
            totalIncomeLabel.Text = "Total Income:";
            // 
            // incomeListBox
            // 
            incomeListBox.FormattingEnabled = true;
            incomeListBox.ItemHeight = 15;
            incomeListBox.Location = new Point(99, 108);
            incomeListBox.Name = "incomeListBox";
            incomeListBox.Size = new Size(259, 184);
            incomeListBox.TabIndex = 3;
            // 
            // totalIncomeTextBox
            // 
            totalIncomeTextBox.Enabled = false;
            totalIncomeTextBox.Location = new Point(224, 27);
            totalIncomeTextBox.Name = "totalIncomeTextBox";
            totalIncomeTextBox.Size = new Size(127, 23);
            totalIncomeTextBox.TabIndex = 6;
            totalIncomeTextBox.Text = "$0";
            totalIncomeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // afterTaxIncomeTextBox
            // 
            afterTaxIncomeTextBox.Enabled = false;
            afterTaxIncomeTextBox.Location = new Point(224, 69);
            afterTaxIncomeTextBox.Name = "afterTaxIncomeTextBox";
            afterTaxIncomeTextBox.Size = new Size(127, 23);
            afterTaxIncomeTextBox.TabIndex = 8;
            afterTaxIncomeTextBox.Text = "$0";
            afterTaxIncomeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // afterTaxIncomeLabel
            // 
            afterTaxIncomeLabel.AutoSize = true;
            afterTaxIncomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            afterTaxIncomeLabel.Location = new Point(75, 67);
            afterTaxIncomeLabel.Name = "afterTaxIncomeLabel";
            afterTaxIncomeLabel.Size = new Size(143, 21);
            afterTaxIncomeLabel.TabIndex = 7;
            afterTaxIncomeLabel.Text = "Income After Tax:";
            afterTaxIncomeLabel.Click += label1_Click;
            // 
            // TotalMonthlyIncome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 369);
            Controls.Add(afterTaxIncomeTextBox);
            Controls.Add(afterTaxIncomeLabel);
            Controls.Add(totalIncomeTextBox);
            Controls.Add(backButton);
            Controls.Add(totalIncomeLabel);
            Controls.Add(incomeListBox);
            Name = "TotalMonthlyIncome";
            Text = "Total Monthly Income";
            Load += TotalMonthlyIncome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Label totalIncomeLabel;
        private ListBox incomeListBox;
        private TextBox totalIncomeTextBox;
        private TextBox afterTaxIncomeTextBox;
        private Label afterTaxIncomeLabel;
    }
}