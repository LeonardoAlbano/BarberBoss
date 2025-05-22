namespace BarberBoss.Domain.Entities
{
    public interface IExpensesRepository
    {
        Task Add(Expense expense);
    }
}
