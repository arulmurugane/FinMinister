using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinMinister.Domain.Common
{
    public class SyncAndAuditableEntity : AuditableEntity
    {
        public DateTime? SyncDateTime { get; set; }
    }
}
