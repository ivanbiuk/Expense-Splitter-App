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
    public partial class CreateListPopup : Form
    {
        public ExpenseList newExpenseList = new ExpenseList();

        public CreateListPopup()
        {
            InitializeComponent();
        }

        private void CreateListPopup_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            string newMemberName = newMemberTextBox.Text;
            if(newMemberName == string.Empty)
                MessageBox.Show("Member needs to have a name", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                var newPerson = new Person(newMemberName);

                newExpenseList.AddMember(newPerson);
                membersListView.Items.Add(newMemberName);
            }
        }

        private void createListButton_Click(object sender, EventArgs e)
        {
            newExpenseList.Name = listNameTextBox.Text;
            if (currencyComboBox.SelectedItem == null)
                newExpenseList.Currency = " ";
            else
                newExpenseList.Currency = currencyComboBox.SelectedItem.ToString();

            if (newExpenseList.Name == string.Empty)
                MessageBox.Show("List needs to have a name", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                if (newExpenseList.Members.Count == 0)
                    MessageBox.Show("List needs to have at least one member", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    this.Close();
            }
        }
    }
}
