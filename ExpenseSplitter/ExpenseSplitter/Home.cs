using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseSplitter
{
    public partial class Home : Form
    {
        public ExpenseList expenseList = new ExpenseList();
        public Home()
        {
            InitializeComponent();
            allExpensesListView.GridLines = false;
        }

        private void createNewListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CreateListPopup = new CreateListPopup();
            CreateListPopup.ShowDialog(this);
            if (!String.IsNullOrWhiteSpace(CreateListPopup.newExpenseList.Name))
            {
                expenseList.ResetList();
                expenseList = CreateListPopup.newExpenseList;
                currentListLabel.Text = expenseList.Name;
                ClearInterface();
            }
            RefreshBalancesListView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addExpenseButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(expenseList.Name))
            {
                var CreateExpensePopup = new CreateExpensePopup(expenseList);
                CreateExpensePopup.ShowDialog(this);
                expenseList = CreateExpensePopup.expenseList;
                RefreshExpenseListView();
                RefreshBalancesListView();
            }
            else
                MessageBox.Show("You need to load a list or create a new one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void RefreshExpenseListView()
        {
            foreach (ListViewItem item in allExpensesListView.Items)
            {
                item.Remove();
            }

            foreach(var expense in expenseList.AllExpenses)
            {
                ListViewItem expenseItem = allExpensesListView.Items.Add(expense.Name);
                expenseItem.SubItems.Add(expense.Cost.ToString());
                expenseItem.SubItems.Add(expense.PaidBy.Name);
                expenseItem.SubItems.Add(expense.ExpenseDate.ToShortDateString());
            }
        }

        private void RefreshBalancesListView()
        {
            foreach (ListViewItem item in balancesListView.Items)
            {
                item.Remove();
            }

            for (int i = 0; i < expenseList.Members.Count(); i++)
            {
                ListViewItem balanceItem = balancesListView.Items.Add(expenseList.Members[i].Name);
                balanceItem.SubItems.Add((expenseList.Members[i].TotalSpent - expenseList.Members[i].TotalShare).ToString());
            }
        }

        private void ClearInterface()
        {
            foreach (ListViewItem item in balancesListView.Items)
            {
                item.Remove();
            }
            foreach (ListViewItem item in allExpensesListView.Items)
            {
                item.Remove();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save your list";
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.FileName = expenseList.Name + ".txt";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile());
                writer.WriteLine(expenseList.Name);
                writer.WriteLine(expenseList.Currency);

                foreach (var member in expenseList.Members)
                    writer.Write(member.Name + " ");
                writer.Write("\r\n");

                foreach (var expense in expenseList.AllExpenses)
                {
                    writer.Write(expense.Name + " " + expense.Cost + " " + expense.ExpenseDate.ToShortDateString() + " " + expense.PaidBy.Name + " ");
                    foreach (var share in expense.Shares)
                        writer.Write(share.ToString() + " ");
                    writer.Write("\r\n");
                }
                writer.Dispose();
                writer.Close();
            }
        }

        private void loadListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            expenseList.ResetList();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                StreamReader reader = new StreamReader(fileName);

                string listName = reader.ReadLine();
                string listCurrency = reader.ReadLine();

                expenseList.Name = listName;
                expenseList.Currency = listCurrency;

                string listMembers = reader.ReadLine();
                foreach (string memberName in listMembers.Split(' '))
                {
                    if (!String.IsNullOrEmpty(memberName))
                    {
                        var newMember = new Person(memberName);
                        expenseList.AddMember(newMember);
                    }
                }

                string expenseLine = reader.ReadLine();
                while (!String.IsNullOrWhiteSpace(expenseLine))
                {
                    string[] expenseElements = expenseLine.Split(' ');
                    var newExpense = new Expense();

                    newExpense.Name = expenseElements[0];
                    newExpense.Cost = Convert.ToDouble(expenseElements[1]);

                    newExpense.ExpenseDate = DateTime.Parse(expenseElements[2]);

                    var paidBy = new Person(expenseElements[3]);
                    newExpense.PaidBy = paidBy;

                    for (int i = 4; i < expenseElements.Length; i++)
                    {
                        if (!String.IsNullOrEmpty(expenseElements[i]))
                        {
                            newExpense.AddNewExpenseShare(Convert.ToDouble(expenseElements[i]));
                            expenseList.Members[i - 4].UpdateTotalShare(Convert.ToDouble(expenseElements[i]) / 100 * newExpense.Cost);
                            if (expenseList.Members[i - 4].Name == paidBy.Name)
                                expenseList.Members[i - 4].UpdateTotalSpent(newExpense.Cost);
                        }
                    }
                    expenseList.AddExpense(newExpense);
                    expenseLine = reader.ReadLine();
                }
                ClearInterface();
                currentListLabel.Text = expenseList.Name;
                
                RefreshExpenseListView();
                RefreshBalancesListView();

                reader.Dispose();
                reader.Close();
            }

        }
    }
}
