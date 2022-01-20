using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinMinister.Application.Contracts.Persistence;
using MediatR;
using FinMinister.Domain.Entities;
using AutoMapper;

namespace FinMinister.Application.Features.Incomes.Command
{
    internal class CreateIncomeCommandHandler:IRequestHandler<CreateIncomeCommand, Guid>
    {
        private readonly IIncomeRepository _incomeRepository;
        private readonly IMapper _mapper;

        public CreateIncomeCommandHandler(IMapper mapper, IIncomeRepository incomeRepository)
        {
            _mapper = mapper;
            _incomeRepository = incomeRepository;
        }

        public async Task<Guid> Handle(CreateIncomeCommand request, CancellationToken cancellation)
        {
            var income = _mapper.Map<Income>(request);
            income = await _incomeRepository.AddAsync(income);
            return income.Id;
        }
    }
}
