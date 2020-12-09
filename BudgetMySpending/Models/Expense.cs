using System.Collections.Generic;

namespace BudgetMySpending.Models
{
    public class Expense
    {
        private List<Expense> expenseCollection = new List<Expense>();
        private EFExpenseRepository expenseRepo;

        public int ExpenseID { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }


        public Expense(int ExpenseID, string Name, decimal Amount) {
            this.ExpenseID = ExpenseID;
            this.Name = Name;
            this.Amount = Amount;
        }

        public Expense() { }
    }
}