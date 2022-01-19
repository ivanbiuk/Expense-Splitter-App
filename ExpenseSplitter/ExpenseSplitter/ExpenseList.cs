using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseSplitter
{
    public class ExpenseList
    {
        public string Name { get; set; }
        public string Currency { get; set; }
        public List<Person> Members { get; set; }
        public List<Expense> AllExpenses { get; set; }
        public double TotalCost { get; set; }

        public ExpenseList()
        {
            Name = " ";
            Currency = " ";
            Members = new List<Person>();
            AllExpenses = new List<Expense>();
            TotalCost = 0;
        }

        public void AddMember(Person newMember)
        {
            Members.Add(newMember);
        }
        public void AddExpense(Expense newExpense)
        {
            AllExpenses.Add(newExpense);
        }
        public void ResetList()
        {
            Name = "";
            Currency = "";
            Members.Clear();
            AllExpenses.Clear();
            TotalCost = 0;
        }

    }
}
