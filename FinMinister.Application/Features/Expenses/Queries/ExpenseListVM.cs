using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinMinister.Application.Features.Expenses
{
    public class ExpenseListVM
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
    }
}
