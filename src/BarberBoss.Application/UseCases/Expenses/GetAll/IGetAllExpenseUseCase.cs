using BarberBoss.Communication.Responses;

namespace BarberBoss.Application.UseCases.Expenses.GetAll
{
    public interface IGetAllExpenseUseCase
    {
        Task<ResponseExpensesJson> Execute();
    }
}