using BarberBoss.Communication.Requests;
using BarberBoss.Communication.Responses;

namespace BarberBoss.Application.UseCases.Expenses.Register
{
    public interface IRegisterExpenseUseCase
    {
        ResponseRegisteredExpenseJson Execute(RequestRegisterExpenseJson request);
    }
}
