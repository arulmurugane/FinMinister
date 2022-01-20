using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace FinMinister.Application.Features.Incomes.Command
{
    public class CreateIncomeCommand: IRequest<Guid>
    {
        public string Source { get; set; }
        public string? Description { get; set; }
        public float Amount { get; set; }
        public int UserId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public override string ToString()
        {
            return $"Income source: {Source}; amount: {Amount}";
        }
    }
}
