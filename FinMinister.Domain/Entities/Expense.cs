using FinMinister.Domain.Common;

namespace FinMinister.Domain.Entities
{
    public class Expense : SyncAndAuditableEntity
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public int UserId { get; set; }
    }
}
