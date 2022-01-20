using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinMinister.Domain.Common;

namespace FinMinister.Domain.Entities
{
    public class Income : SyncAndAuditableEntity
    {
        public Guid Id { get; set; }
        public string Source { get; set; }
        public string? Description { get; set; }
        public double Amount { get; set; }
        public int UserId { get; set; }
    }
}
