using BarberBoss.Communication.Responses;

namespace BarberBoss.Application.UseCases.Expenses.GetById
{
    public interface IGetExpenseByIdUseCase
    {
        Task<ResponseExpenseJson> Execute(long id);
    }
}
