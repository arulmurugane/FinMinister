using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinMinister.Application.Features.Expenses.Command
{
    public class CreateExpenseCommand:IRequest<Guid>
    {
        public string Category { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }
        public int UserId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public override string ToString()
        {
            return $"Expense category: {Category}; spent on: {Description}; amount: {Amount}";
        }
    }
}
