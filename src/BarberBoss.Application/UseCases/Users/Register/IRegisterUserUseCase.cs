using BarberBoss.Communication.Requests;
using BarberBoss.Communication.Responses;

namespace CashFlow.Application.UseCases.Users.Register;
public interface IRegisterUserUseCase
{
    Task<ResponseRegisteredUserJson> Execute(RequestRegisterUserJson request);
}
