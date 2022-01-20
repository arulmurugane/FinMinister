using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace FinMinister.Application.Features.Incomes.Queries
{
    public class GetIncomeListQuery :IRequest<List<IncomeListVM>>
    {
        public int UserId { get; set; }
    }
}
