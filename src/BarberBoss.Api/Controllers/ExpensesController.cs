using BarberBoss.Application.UseCases.Expenses.Register;
using BarberBoss.Communication.Requests;
using BarberBoss.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BarberBoss.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] RequestRegisterExpenseJson request)
        {
            try
            {
                var useCase = new RegisterExpenseUseCase();

                var response = useCase.Execute(request);

                return Created(string.Empty, response);
            }
            catch (ArgumentException ex)
            {
                var errorReponse = new ResponseErrorJson(ex.Message);

                return BadRequest(errorReponse);
            }
            catch
            {
                var errorReponse = new ResponseErrorJson("unknown error");

                return StatusCode(StatusCodes.Status500InternalServerError, errorReponse);
            }
        }
    }
}
