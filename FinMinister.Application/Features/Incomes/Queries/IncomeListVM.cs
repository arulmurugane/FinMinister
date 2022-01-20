using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinMinister.Application.Features.Incomes.Queries
{
    public class IncomeListVM
    {
        public Guid Id { get; set; }
        public string Source { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
    }
}
