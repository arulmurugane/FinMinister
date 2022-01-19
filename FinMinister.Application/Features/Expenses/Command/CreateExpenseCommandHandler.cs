using FinMinister.Application.Contracts.Persistence;
using MediatR;
using FinMinister.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinMinister.Application.Features.Expenses.Command
{
    internal class CreateExpenseCommandHandler:IRequestHandler<CreateExpenseCommand, Guid>
    {
        private readonly IExpenseRepository _expenseRepository;
        private readonly IMapper _mapper;

        public CreateExpenseCommandHandler(IMapper mapper, IExpenseRepository expenseRepository)
        {
            _mapper = mapper;
            _expenseRepository = expenseRepository;
        }

        public async Task<Guid> Handle(CreateExpenseCommand request, CancellationToken cancellation)
        {
            var expense = _mapper.Map<Expense>(request);
            expense = await _expenseRepository.AddAsync(expense);
            return expense.Id;
        }
    }
}
