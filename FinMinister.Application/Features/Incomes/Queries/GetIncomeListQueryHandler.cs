using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FinMinister.Application.Contracts.Persistence;
using MediatR;

namespace FinMinister.Application.Features.Incomes.Queries
{
    public class GetIncomeListQueryHandler:IRequestHandler<GetIncomeListQuery, List<IncomeListVM>>
    {
        private readonly IIncomeRepository _incomeRepository;
        private readonly IMapper _mapper;

        public GetIncomeListQueryHandler(IMapper mapper, IIncomeRepository incomeRepository)
        {
            _mapper = mapper;
            _incomeRepository = incomeRepository;
        }

        public async Task<List<IncomeListVM>> Handle(GetIncomeListQuery request, CancellationToken cancellation)
        {
            var allIncome = await _incomeRepository.GetIncomeListByUserIdAsync(request.UserId);
            return _mapper.Map<List<IncomeListVM>>(allIncome);
        }

    }
}
