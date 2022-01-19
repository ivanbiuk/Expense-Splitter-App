using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseSplitter
{
    public class Expense
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public Person PaidBy { get; set; }
        public DateTime ExpenseDate { get; set; }
        public List<double> Shares { get; set; }

        public Expense()
        {
            Name = " ";
            Cost = 0;
            Shares = new List<double>();
        }
        public void AddNewExpenseShare(double newShare)
        {
            Shares.Add(newShare);
        }
    }
}
