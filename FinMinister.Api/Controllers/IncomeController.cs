using FinMinister.Application.Features.Incomes.Command;
using FinMinister.Application.Features.Incomes.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinMinister.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncomeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public IncomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{userId}", Name = "GetIncomeById")]
        public async Task<ActionResult<List<IncomeListVM>>> GetAllExpense(int userId)
        {
            var dtos = await _mediator.Send(new GetIncomeListQuery() { UserId = userId });
            return Ok(dtos);
        }

        [HttpPost(Name = "AddIncome")]
        public async Task<ActionResult<Guid>> AddIncome([FromBody] CreateIncomeCommand createIncomeCommand)
        {
            var id = await _mediator.Send(createIncomeCommand);
            return Ok(id);
        }

    }
}
