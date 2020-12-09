using BudgetMySpending.Controllers;
using BudgetMySpending.Models;
using NUnit.Framework;

namespace UnitTestBudgetMySpending

{
    //private IExpenseRepository expenseRepository;
    //private IBudgetRepository budgetRepository;

    public class Tests
    {
        private IBudgetRepository budgetRepository;
        private IExpenseRepository expenseRepository;
        private HomeController homeController;
        

        [SetUp]
        public void Setup()
        {
            homeController = new HomeController(expenseRepository, budgetRepository);
            Expense expense = new Expense();
            Budget budget = new Budget();
        }

        [Test]
        public void Test1()
        {
            const string Name = "Car";
            const decimal Amount = 123;

            Expense expense = GetExpense(Name, Amount);
            Assert.AreEqual(Name, expense.Name);
        }

        private static Expense GetExpense(string Name, decimal Amount)
        {
            return new Expense(Name, Amount);
        }
    }
}