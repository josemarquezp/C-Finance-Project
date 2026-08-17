namespace Income_and_Taxes
{
    partial class ExpensesForm
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
            expensesListBox = new ListBox();
            expensesLabel = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // expensesListBox
            // 
            expensesListBox.FormattingEnabled = true;
            expensesListBox.ItemHeight = 15;
            expensesListBox.Location = new Point(86, 71);
            expensesListBox.Name = "expensesListBox";
            expensesListBox.Size = new Size(259, 184);
            expensesListBox.TabIndex = 0;
            expensesListBox.SelectedIndexChanged += expensesListBox_SelectedIndexChanged;
            // 
            // expensesLabel
            // 
            expensesLabel.AutoSize = true;
            expensesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            expensesLabel.Location = new Point(173, 24);
            expensesLabel.Name = "expensesLabel";
            expensesLabel.Size = new Size(84, 21);
            expensesLabel.TabIndex = 1;
            expensesLabel.Text = "Expenses ";
            // 
            // backButton
            // 
            backButton.Location = new Point(178, 282);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 2;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // ExpensesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 329);
            Controls.Add(backButton);
            Controls.Add(expensesLabel);
            Controls.Add(expensesListBox);
            Name = "ExpensesForm";
            Text = "Expenses Form";
            Load += ExpensesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox expensesListBox;
        private Label expensesLabel;
        private Button backButton;
    }
}