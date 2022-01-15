using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinMinister.Application.Features.Expenses.Command
{
    public class CreateExpenseCommand:IRequest<int>
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }
        public int UserId { get; set; }

        public override string ToString()
        {
            return $"Expense category: {Category}; spent on: {Description}; amount: {Amount}";
        }
    }
}
