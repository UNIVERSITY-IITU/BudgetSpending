namespace BudgetMySpending.Models
{
    public class Budget
    {


        public int BudgetID { get; set; }
        public decimal Amount { get; set; }

        public Budget(int BudgetID, decimal Amount)
        {
            this.BudgetID = BudgetID;
            this.Amount = Amount;
        }
        public Budget() { }
    }
}
