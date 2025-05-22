using BarberBoss.Domain.Entities;

namespace BarberBoss.Domain.Repositories.Expenses
{
    public interface IExpensesUpdateOnlyRepository
    {
        Task<Expense?> GetById(long id);
        void Update(Expense expense);
    }
}
