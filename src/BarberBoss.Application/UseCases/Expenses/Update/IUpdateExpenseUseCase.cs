using BarberBoss.Communication.Requests;

namespace BarberBoss.Application.UseCases.Expenses.Update
{
    public interface IUpdateExpenseUseCase
    {
        Task Execute(long id, RequestExpenseJson request);
    }
}
