using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseSplitter
{
    public partial class CreateExpensePopup : Form
    {
        public ExpenseList expenseList = new ExpenseList();
        public Expense newExpense = new Expense();
        public CreateExpensePopup(ExpenseList myExpenseList)
        {
            InitializeComponent();
            expenseList = myExpenseList;
            expenseCurrencyLabel.Text = expenseList.Currency.ToString();

            for (int i = 0; i < expenseList.Members.Count(); i++)
            {
                Label newMemberLabel = new Label();
                expenseFlowLayoutPanel.Controls.Add(newMemberLabel);
                newMemberLabel.Text = expenseList.Members[i].Name.ToString();
                newMemberLabel.Margin = new Padding(5, 10, 5, 2);

                NumericUpDown newNumericUpDown = new NumericUpDown();
                expenseFlowLayoutPanel.Controls.Add(newNumericUpDown);
                newNumericUpDown.Size = new Size(200, 10);
                newNumericUpDown.Margin = new Padding(5, 2, 5, 15);
                newNumericUpDown.Maximum = 100;
                newNumericUpDown.DecimalPlaces = 2;

                RadioButton newPayer = new RadioButton();
                newPayer.Text = expenseList.Members[i].Name.ToString();
                paidByFlowLayoutPanel.Controls.Add(newPayer);
            }
        }

        private void CreateExpensePopup_Load(object sender, EventArgs e)
        {

        }


        private void splitEquallyButton_Click(object sender, EventArgs e)
        {
            foreach (NumericUpDown a in expenseFlowLayoutPanel.Controls.OfType<NumericUpDown>())
                a.Value = (100 / (decimal)expenseList.Members.Count());
        }

        private void addExpenseButton_Click(object sender, EventArgs e)
        {
            var totalShares = new decimal();
            bool isPayerChecked = false;
            int memberSharesFlag = 0;
            int selectedMemberNumber = 0;

            foreach (NumericUpDown a in expenseFlowLayoutPanel.Controls.OfType<NumericUpDown>())
            {
                totalShares += a.Value;
            }

            foreach (RadioButton r in paidByFlowLayoutPanel.Controls.OfType<RadioButton>())
            {
                if (r.Checked == true) //loops through all radiobuttons to see if one is checked and finds which person was checked
                {
                    isPayerChecked = true;
                    break;
                }
                else
                    selectedMemberNumber++;
            }

            if (totalShares == 100)
            {
                if (isPayerChecked)
                {
                    newExpense.Name = expenseNameTextBox.Text;
                    if (expenseNumericUpDown.Value != 0)
                    {
                        newExpense.Cost = decimal.ToDouble(expenseNumericUpDown.Value);
                        newExpense.ExpenseDate = expenseDateTimePicker.Value;
                        expenseList.TotalCost += newExpense.Cost;

                        foreach (NumericUpDown a in expenseFlowLayoutPanel.Controls.OfType<NumericUpDown>())
                        {
                            newExpense.AddNewExpenseShare(decimal.ToDouble(a.Value));
                            expenseList.Members[memberSharesFlag].UpdateTotalShare((decimal.ToDouble(a.Value) / 100) * newExpense.Cost);
                            memberSharesFlag++;
                        }

                        newExpense.PaidBy = expenseList.Members[selectedMemberNumber];
                        expenseList.Members[selectedMemberNumber].UpdateTotalSpent(newExpense.Cost);

                        expenseList.AddExpense(newExpense);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Expense cost can't be 0", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    MessageBox.Show("You need to choose a payer", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Total inserted shares are different from 100%, please try again!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
