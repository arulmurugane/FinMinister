using FinMinister.Domain.Common;
namespace FinMinister.Domain.Entities
{
    public class User : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phonenumber { get; set; }
    }
}