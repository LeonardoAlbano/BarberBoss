using BarberBoss.Domain.Entities;

namespace BarberBoss.Infrastructure.DataAccess.Repositories
{
    internal class ExpensesRepository : IExpensesRepository
    {
        private readonly BarberBossDbContext _dbContext;

        public ExpensesRepository(BarberBossDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Expense expense)
        {

            _dbContext.Expenses.Add(expense);

            _dbContext.SaveChanges();
        }
    }
}
