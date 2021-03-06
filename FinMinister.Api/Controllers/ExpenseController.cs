using FinMinister.Application.Features.Expenses.Queries;
using FinMinister.Application.Features.Expenses.Command;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FinMinister.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExpenseController(IMediator mediator)
        { 
            _mediator = mediator;
        }

        [HttpGet("{userId}", Name = "GetExpenseById")]
        public async Task<ActionResult<List<ExpenseListVM>>> GetAllExpense(int userId)
        {
            var dtos = await _mediator.Send(new GetExpenseListQuery() { UserId = userId });
            return Ok(dtos);
        }

        [HttpPost(Name = "AddExpense")]
        public async Task<ActionResult<Guid>> AddExpense([FromBody]CreateExpenseCommand createExpenseCommand)
        {
            var id = await _mediator.Send(createExpenseCommand);
            return Ok(id);
        }
    }
}
