using FinMinister.Domain.Entities;

namespace FinMinister.Application.Contracts.Persistence
{
    public interface IIncomeRepository : IAsyncRepository<Income>
    {
        Task<IReadOnlyList<Income>> GetIncomeListByUserIdAsync(int userId);
    }
    
}
