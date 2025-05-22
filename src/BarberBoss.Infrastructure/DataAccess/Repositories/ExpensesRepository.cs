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
        public async Task Add(Expense expense)
        {
            await _dbContext.Expenses.AddAsync(expense);

        }
    }
}
