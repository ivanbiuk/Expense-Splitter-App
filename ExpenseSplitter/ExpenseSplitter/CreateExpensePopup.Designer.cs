
namespace ExpenseSplitter
{
    partial class CreateExpensePopup
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
            this.expenseNameLabel = new System.Windows.Forms.Label();
            this.expenseNameTextBox = new System.Windows.Forms.TextBox();
            this.expenseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expenseDateLabel = new System.Windows.Forms.Label();
            this.expenseCostLabel = new System.Windows.Forms.Label();
            this.expenseNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.expenseCurrencyLabel = new System.Windows.Forms.Label();
            this.expenseFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sharesLabel = new System.Windows.Forms.Label();
            this.splitEquallyButton = new System.Windows.Forms.Button();
            this.addExpenseButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.paidByFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.paidByLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.expenseNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // expenseNameLabel
            // 
            this.expenseNameLabel.AutoSize = true;
            this.expenseNameLabel.Location = new System.Drawing.Point(49, 38);
            this.expenseNameLabel.Name = "expenseNameLabel";
            this.expenseNameLabel.Size = new System.Drawing.Size(49, 17);
            this.expenseNameLabel.TabIndex = 0;
            this.expenseNameLabel.Text = "Name:";
            // 
            // expenseNameTextBox
            // 
            this.expenseNameTextBox.Location = new System.Drawing.Point(112, 35);
            this.expenseNameTextBox.Name = "expenseNameTextBox";
            this.expenseNameTextBox.Size = new System.Drawing.Size(181, 22);
            this.expenseNameTextBox.TabIndex = 1;
            // 
            // expenseDateTimePicker
            // 
            this.expenseDateTimePicker.Location = new System.Drawing.Point(111, 135);
            this.expenseDateTimePicker.Name = "expenseDateTimePicker";
            this.expenseDateTimePicker.Size = new System.Drawing.Size(182, 22);
            this.expenseDateTimePicker.TabIndex = 3;
            // 
            // expenseDateLabel
            // 
            this.expenseDateLabel.AutoSize = true;
            this.expenseDateLabel.Location = new System.Drawing.Point(56, 135);
            this.expenseDateLabel.Name = "expenseDateLabel";
            this.expenseDateLabel.Size = new System.Drawing.Size(42, 17);
            this.expenseDateLabel.TabIndex = 4;
            this.expenseDateLabel.Text = "Date:";
            // 
            // expenseCostLabel
            // 
            this.expenseCostLabel.AutoSize = true;
            this.expenseCostLabel.Location = new System.Drawing.Point(56, 88);
            this.expenseCostLabel.Name = "expenseCostLabel";
            this.expenseCostLabel.Size = new System.Drawing.Size(40, 17);
            this.expenseCostLabel.TabIndex = 5;
            this.expenseCostLabel.Text = "Cost:";
            // 
            // expenseNumericUpDown
            // 
            this.expenseNumericUpDown.DecimalPlaces = 2;
            this.expenseNumericUpDown.Location = new System.Drawing.Point(111, 86);
            this.expenseNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.expenseNumericUpDown.Name = "expenseNumericUpDown";
            this.expenseNumericUpDown.Size = new System.Drawing.Size(182, 22);
            this.expenseNumericUpDown.TabIndex = 6;
            // 
            // expenseCurrencyLabel
            // 
            this.expenseCurrencyLabel.AutoSize = true;
            this.expenseCurrencyLabel.Location = new System.Drawing.Point(311, 88);
            this.expenseCurrencyLabel.Name = "expenseCurrencyLabel";
            this.expenseCurrencyLabel.Size = new System.Drawing.Size(0, 17);
            this.expenseCurrencyLabel.TabIndex = 7;
            // 
            // expenseFlowLayoutPanel
            // 
            this.expenseFlowLayoutPanel.AutoScroll = true;
            this.expenseFlowLayoutPanel.Location = new System.Drawing.Point(484, 35);
            this.expenseFlowLayoutPanel.Name = "expenseFlowLayoutPanel";
            this.expenseFlowLayoutPanel.Size = new System.Drawing.Size(258, 240);
            this.expenseFlowLayoutPanel.TabIndex = 8;
            // 
            // sharesLabel
            // 
            this.sharesLabel.AutoSize = true;
            this.sharesLabel.Location = new System.Drawing.Point(395, 38);
            this.sharesLabel.Name = "sharesLabel";
            this.sharesLabel.Size = new System.Drawing.Size(83, 17);
            this.sharesLabel.TabIndex = 9;
            this.sharesLabel.Text = "Shares (%):";
            // 
            // splitEquallyButton
            // 
            this.splitEquallyButton.Location = new System.Drawing.Point(520, 291);
            this.splitEquallyButton.Name = "splitEquallyButton";
            this.splitEquallyButton.Size = new System.Drawing.Size(192, 34);
            this.splitEquallyButton.TabIndex = 10;
            this.splitEquallyButton.Text = "Split Equally";
            this.splitEquallyButton.UseVisualStyleBackColor = true;
            this.splitEquallyButton.Click += new System.EventHandler(this.splitEquallyButton_Click);
            // 
            // addExpenseButton
            // 
            this.addExpenseButton.Location = new System.Drawing.Point(308, 349);
            this.addExpenseButton.Name = "addExpenseButton";
            this.addExpenseButton.Size = new System.Drawing.Size(170, 68);
            this.addExpenseButton.TabIndex = 11;
            this.addExpenseButton.Text = "Add Expense";
            this.addExpenseButton.UseVisualStyleBackColor = true;
            this.addExpenseButton.Click += new System.EventHandler(this.addExpenseButton_Click);
            // 
            // paidByFlowLayoutPanel
            // 
            this.paidByFlowLayoutPanel.Location = new System.Drawing.Point(111, 183);
            this.paidByFlowLayoutPanel.Name = "paidByFlowLayoutPanel";
            this.paidByFlowLayoutPanel.Size = new System.Drawing.Size(206, 128);
            this.paidByFlowLayoutPanel.TabIndex = 12;
            // 
            // paidByLabel
            // 
            this.paidByLabel.AutoSize = true;
            this.paidByLabel.Location = new System.Drawing.Point(38, 183);
            this.paidByLabel.Name = "paidByLabel";
            this.paidByLabel.Size = new System.Drawing.Size(60, 17);
            this.paidByLabel.TabIndex = 13;
            this.paidByLabel.Text = "Paid By:";
            // 
            // CreateExpensePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paidByLabel);
            this.Controls.Add(this.paidByFlowLayoutPanel);
            this.Controls.Add(this.addExpenseButton);
            this.Controls.Add(this.splitEquallyButton);
            this.Controls.Add(this.sharesLabel);
            this.Controls.Add(this.expenseFlowLayoutPanel);
            this.Controls.Add(this.expenseCurrencyLabel);
            this.Controls.Add(this.expenseNumericUpDown);
            this.Controls.Add(this.expenseCostLabel);
            this.Controls.Add(this.expenseDateLabel);
            this.Controls.Add(this.expenseDateTimePicker);
            this.Controls.Add(this.expenseNameTextBox);
            this.Controls.Add(this.expenseNameLabel);
            this.Name = "CreateExpensePopup";
            this.Text = "CreateExpensePopup";
            this.Load += new System.EventHandler(this.CreateExpensePopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expenseNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label expenseNameLabel;
        private System.Windows.Forms.TextBox expenseNameTextBox;
        private System.Windows.Forms.DateTimePicker expenseDateTimePicker;
        private System.Windows.Forms.Label expenseDateLabel;
        private System.Windows.Forms.Label expenseCostLabel;
        private System.Windows.Forms.NumericUpDown expenseNumericUpDown;
        private System.Windows.Forms.Label expenseCurrencyLabel;
        private System.Windows.Forms.FlowLayoutPanel expenseFlowLayoutPanel;
        private System.Windows.Forms.Label sharesLabel;
        private System.Windows.Forms.Button splitEquallyButton;
        private System.Windows.Forms.Button addExpenseButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel paidByFlowLayoutPanel;
        private System.Windows.Forms.Label paidByLabel;
    }
}