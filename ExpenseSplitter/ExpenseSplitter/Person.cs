using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseSplitter
{
    public class Person
    {
        public string Name { get; set; }
        public double TotalSpent { get; set; }
        public double TotalShare { get; set; }

        public Person(string inputName)
        {
            Name = inputName;
            TotalSpent = 0;
            TotalShare = 0;
        }


        public void UpdateTotalSpent(double newCost)
        {
            TotalSpent += newCost;
        }

        public void UpdateTotalShare(double newShare)
        {
            TotalShare += newShare;
        }
    }
}
