using FinMinister.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinMinister.Domain.Entities
{
    public class Expense : AuditableEntity
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public int UserId { get; set; }
    }
}
