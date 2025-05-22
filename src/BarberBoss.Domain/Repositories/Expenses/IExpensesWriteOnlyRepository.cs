using BarberBoss.Domain.Entities;

namespace BarberBoss.Domain.Repositories.Expenses
{
    public interface IExpensesWriteOnlyRepository
    {
        Task Add(Expense expense);

    }
}
