using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinMinister.Application.Features.Expenses.Queries
{
    public class GetExpenseListQuery : IRequest<List<ExpenseListVM>>
    {
        public int UserId { get; set; }
    }
}
