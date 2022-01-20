using FinMinister.Domain.Entities;

namespace FinMinister.Application.Contracts.Persistence
{
    public interface IExpenseRepository : IAsyncRepository<Expense>
    {
        Task<IReadOnlyList<Expense>> GetExpenseListByUserIdAsync(int userId);
    }

}
