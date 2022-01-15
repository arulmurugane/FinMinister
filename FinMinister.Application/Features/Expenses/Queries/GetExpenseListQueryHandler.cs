using AutoMapper;
using FinMinister.Application.Contracts.Persistence;
using FinMinister.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinMinister.Application.Features.Expenses
{
    public class GetExpenseListQueryHandler:IRequestHandler<GetExpenseListQuery, List<ExpenseListVM>>
    {
        private readonly IExpenseRepository _expenseRepository;
        private readonly IMapper _mapper;

        public GetExpenseListQueryHandler(IMapper mapper, IExpenseRepository expenseRepository)
        { 
            _mapper = mapper;
            _expenseRepository = expenseRepository;
        }

        public async Task<List<ExpenseListVM>> Handle(GetExpenseListQuery request, CancellationToken cancellation)
        {
            var allExpense = (await _expenseRepository.GetExpenseListByUserIdAsync(request.UserId));
            return _mapper.Map<List<ExpenseListVM>>(allExpense);
        }
    }
}
