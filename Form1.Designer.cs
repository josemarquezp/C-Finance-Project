namespace Income_and_Taxes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            incomeSource = new Label();
            incomeAmount = new Label();
            incomeSourceTextBox = new TextBox();
            incomeAmountTextBox = new TextBox();
            pushButton = new Button();
            exitButton = new Button();
            incomeAfterTaxLabel = new Label();
            balanceLabel = new Label();
            taxLabel = new Label();
            incomeAfterTaxTextBox = new TextBox();
            balanceTextBox = new TextBox();
            taxAmountTextBox = new TextBox();
            expensestTextBox = new TextBox();
            expensesLabel = new Label();
            clearButton = new Button();
            nameLabel = new Label();
            infoLabel = new Label();
            expensesButton = new Button();
            taxRadio1 = new RadioButton();
            taxRadio2 = new RadioButton();
            taxRadio3 = new RadioButton();
            taxRadio4 = new RadioButton();
            taxRadio5 = new RadioButton();
            taxRadio6 = new RadioButton();
            taxRadio7 = new RadioButton();
            taxGroupBox = new GroupBox();
            incomeButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            taxGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // incomeSource
            // 
            incomeSource.AutoSize = true;
            incomeSource.Location = new Point(48, 33);
            incomeSource.Name = "incomeSource";
            incomeSource.Size = new Size(89, 15);
            incomeSource.TabIndex = 0;
            incomeSource.Text = "Income Source:";
            // 
            // incomeAmount
            // 
            incomeAmount.AutoSize = true;
            incomeAmount.Location = new Point(42, 69);
            incomeAmount.Name = "incomeAmount";
            incomeAmount.Size = new Size(97, 15);
            incomeAmount.TabIndex = 1;
            incomeAmount.Text = "Income Amount:";
            // 
            // incomeSourceTextBox
            // 
            incomeSourceTextBox.BorderStyle = BorderStyle.FixedSingle;
            incomeSourceTextBox.Location = new Point(149, 31);
            incomeSourceTextBox.Name = "incomeSourceTextBox";
            incomeSourceTextBox.Size = new Size(100, 23);
            incomeSourceTextBox.TabIndex = 2;
            // 
            // incomeAmountTextBox
            // 
            incomeAmountTextBox.BorderStyle = BorderStyle.FixedSingle;
            incomeAmountTextBox.Location = new Point(149, 67);
            incomeAmountTextBox.Name = "incomeAmountTextBox";
            incomeAmountTextBox.Size = new Size(100, 23);
            incomeAmountTextBox.TabIndex = 3;
            // 
            // pushButton
            // 
            pushButton.Location = new Point(100, 261);
            pushButton.Name = "pushButton";
            pushButton.Size = new Size(75, 23);
            pushButton.TabIndex = 4;
            pushButton.Text = "Push";
            pushButton.UseVisualStyleBackColor = true;
            pushButton.Click += pushButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(100, 319);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // incomeAfterTaxLabel
            // 
            incomeAfterTaxLabel.AutoSize = true;
            incomeAfterTaxLabel.Location = new Point(293, 61);
            incomeAfterTaxLabel.Name = "incomeAfterTaxLabel";
            incomeAfterTaxLabel.Size = new Size(99, 15);
            incomeAfterTaxLabel.TabIndex = 6;
            incomeAfterTaxLabel.Text = "Income After Tax:";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new Point(293, 169);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(102, 15);
            balanceLabel.TabIndex = 7;
            balanceLabel.Text = "Monthly Balance: ";
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.Location = new Point(318, 31);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(74, 15);
            taxLabel.TabIndex = 8;
            taxLabel.Text = "Tax Amount:";
            // 
            // incomeAfterTaxTextBox
            // 
            incomeAfterTaxTextBox.BorderStyle = BorderStyle.FixedSingle;
            incomeAfterTaxTextBox.Enabled = false;
            incomeAfterTaxTextBox.Location = new Point(398, 58);
            incomeAfterTaxTextBox.Name = "incomeAfterTaxTextBox";
            incomeAfterTaxTextBox.Size = new Size(100, 23);
            incomeAfterTaxTextBox.TabIndex = 9;
            // 
            // balanceTextBox
            // 
            balanceTextBox.BorderStyle = BorderStyle.FixedSingle;
            balanceTextBox.Enabled = false;
            balanceTextBox.Location = new Point(398, 167);
            balanceTextBox.Name = "balanceTextBox";
            balanceTextBox.Size = new Size(100, 23);
            balanceTextBox.TabIndex = 10;
            // 
            // taxAmountTextBox
            // 
            taxAmountTextBox.BorderStyle = BorderStyle.FixedSingle;
            taxAmountTextBox.Enabled = false;
            taxAmountTextBox.Location = new Point(398, 29);
            taxAmountTextBox.Name = "taxAmountTextBox";
            taxAmountTextBox.Size = new Size(100, 23);
            taxAmountTextBox.TabIndex = 11;
            // 
            // expensestTextBox
            // 
            expensestTextBox.BorderStyle = BorderStyle.FixedSingle;
            expensestTextBox.Enabled = false;
            expensestTextBox.Location = new Point(398, 87);
            expensestTextBox.Name = "expensestTextBox";
            expensestTextBox.Size = new Size(100, 23);
            expensestTextBox.TabIndex = 13;
            // 
            // expensesLabel
            // 
            expensesLabel.AutoSize = true;
            expensesLabel.Location = new Point(306, 89);
            expensesLabel.Name = "expensesLabel";
            expensesLabel.Size = new Size(86, 15);
            expensesLabel.TabIndex = 12;
            expensesLabel.Text = "Total Expenses:";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(100, 290);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 14;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(420, 373);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(78, 15);
            nameLabel.TabIndex = 15;
            nameLabel.Text = "Jose Marquez";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(29, 352);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(481, 15);
            infoLabel.TabIndex = 16;
            infoLabel.Text = "Enter income source and amount, then click Push. Expenses are loaded from expenses.txt.";
            // 
            // expensesButton
            // 
            expensesButton.Location = new Point(345, 261);
            expensesButton.Name = "expensesButton";
            expensesButton.Size = new Size(117, 23);
            expensesButton.TabIndex = 17;
            expensesButton.Text = "View Expenses";
            expensesButton.UseVisualStyleBackColor = true;
            expensesButton.Click += expensesButton_Click;
            // 
            // taxRadio1
            // 
            taxRadio1.AutoSize = true;
            taxRadio1.Location = new Point(15, 22);
            taxRadio1.Name = "taxRadio1";
            taxRadio1.Size = new Size(47, 19);
            taxRadio1.TabIndex = 18;
            taxRadio1.TabStop = true;
            taxRadio1.Text = "10%";
            taxRadio1.UseVisualStyleBackColor = true;
            // 
            // taxRadio2
            // 
            taxRadio2.AutoSize = true;
            taxRadio2.Location = new Point(15, 44);
            taxRadio2.Name = "taxRadio2";
            taxRadio2.Size = new Size(47, 19);
            taxRadio2.TabIndex = 19;
            taxRadio2.TabStop = true;
            taxRadio2.Text = "12%";
            taxRadio2.UseVisualStyleBackColor = true;
            // 
            // taxRadio3
            // 
            taxRadio3.AutoSize = true;
            taxRadio3.Location = new Point(15, 69);
            taxRadio3.Name = "taxRadio3";
            taxRadio3.Size = new Size(47, 19);
            taxRadio3.TabIndex = 20;
            taxRadio3.TabStop = true;
            taxRadio3.Text = "22%";
            taxRadio3.UseVisualStyleBackColor = true;
            // 
            // taxRadio4
            // 
            taxRadio4.AutoSize = true;
            taxRadio4.Location = new Point(15, 94);
            taxRadio4.Name = "taxRadio4";
            taxRadio4.Size = new Size(47, 19);
            taxRadio4.TabIndex = 21;
            taxRadio4.TabStop = true;
            taxRadio4.Text = "24%";
            taxRadio4.UseVisualStyleBackColor = true;
            // 
            // taxRadio5
            // 
            taxRadio5.AutoSize = true;
            taxRadio5.Location = new Point(72, 22);
            taxRadio5.Name = "taxRadio5";
            taxRadio5.Size = new Size(47, 19);
            taxRadio5.TabIndex = 22;
            taxRadio5.TabStop = true;
            taxRadio5.Text = "32%";
            taxRadio5.UseVisualStyleBackColor = true;
            // 
            // taxRadio6
            // 
            taxRadio6.AutoSize = true;
            taxRadio6.Location = new Point(72, 47);
            taxRadio6.Name = "taxRadio6";
            taxRadio6.Size = new Size(47, 19);
            taxRadio6.TabIndex = 23;
            taxRadio6.TabStop = true;
            taxRadio6.Text = "35%";
            taxRadio6.UseVisualStyleBackColor = true;
            // 
            // taxRadio7
            // 
            taxRadio7.AutoSize = true;
            taxRadio7.Location = new Point(72, 72);
            taxRadio7.Name = "taxRadio7";
            taxRadio7.Size = new Size(47, 19);
            taxRadio7.TabIndex = 24;
            taxRadio7.TabStop = true;
            taxRadio7.Text = "37%";
            taxRadio7.UseVisualStyleBackColor = true;
            // 
            // taxGroupBox
            // 
            taxGroupBox.Controls.Add(taxRadio1);
            taxGroupBox.Controls.Add(taxRadio2);
            taxGroupBox.Controls.Add(taxRadio7);
            taxGroupBox.Controls.Add(taxRadio3);
            taxGroupBox.Controls.Add(taxRadio6);
            taxGroupBox.Controls.Add(taxRadio4);
            taxGroupBox.Controls.Add(taxRadio5);
            taxGroupBox.Location = new Point(75, 115);
            taxGroupBox.Name = "taxGroupBox";
            taxGroupBox.Size = new Size(131, 125);
            taxGroupBox.TabIndex = 26;
            taxGroupBox.TabStop = false;
            taxGroupBox.Text = "Tax Bracket";
            // 
            // incomeButton
            // 
            incomeButton.Location = new Point(345, 232);
            incomeButton.Name = "incomeButton";
            incomeButton.Size = new Size(117, 23);
            incomeButton.TabIndex = 27;
            incomeButton.Text = "View Income";
            incomeButton.UseVisualStyleBackColor = true;
            incomeButton.Click += incomeButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2026_04_29_112044;
            pictureBox1.Location = new Point(270, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2026_04_29_112219;
            pictureBox2.Location = new Point(283, 84);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Screenshot_2026_04_29_112345;
            pictureBox3.Location = new Point(295, 24);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Screenshot_2026_04_29_112425;
            pictureBox4.Location = new Point(272, 161);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 412);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(incomeButton);
            Controls.Add(taxGroupBox);
            Controls.Add(expensesButton);
            Controls.Add(infoLabel);
            Controls.Add(nameLabel);
            Controls.Add(clearButton);
            Controls.Add(expensestTextBox);
            Controls.Add(expensesLabel);
            Controls.Add(taxAmountTextBox);
            Controls.Add(balanceTextBox);
            Controls.Add(incomeAfterTaxTextBox);
            Controls.Add(taxLabel);
            Controls.Add(balanceLabel);
            Controls.Add(incomeAfterTaxLabel);
            Controls.Add(exitButton);
            Controls.Add(pushButton);
            Controls.Add(incomeAmountTextBox);
            Controls.Add(incomeSourceTextBox);
            Controls.Add(incomeAmount);
            Controls.Add(incomeSource);
            Name = "Form1";
            Text = "Income and Taxes 1099";
            Load += Form1_Load;
            taxGroupBox.ResumeLayout(false);
            taxGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label incomeSource;
        private Label incomeAmount;
        private TextBox incomeSourceTextBox;
        private TextBox incomeAmountTextBox;
        private Button pushButton;
        private Button exitButton;
        private Label incomeAfterTaxLabel;
        private Label balanceLabel;
        private Label taxLabel;
        private TextBox incomeAfterTaxTextBox;
        private TextBox balanceTextBox;
        private TextBox taxAmountTextBox;
        private TextBox expensestTextBox;
        private Label expensesLabel;
        private Button clearButton;
        private Label nameLabel;
        private Label infoLabel;
        private Button expensesButton;
        private RadioButton taxRadio1;
        private RadioButton taxRadio2;
        private RadioButton taxRadio3;
        private RadioButton taxRadio4;
        private RadioButton taxRadio5;
        private RadioButton taxRadio6;
        private RadioButton taxRadio7;
        private GroupBox taxGroupBox;
        private Button incomeButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
