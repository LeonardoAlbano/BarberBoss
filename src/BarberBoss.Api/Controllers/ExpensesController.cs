﻿using BarberBoss.Application.UseCases.Expenses.Register;
using BarberBoss.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace BarberBoss.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register(
        [FromServices] IRegisterExpenseUseCase useCase,
        [FromBody] RequestRegisterExpenseJson request)
        {
            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }

    }
}
