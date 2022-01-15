using FinMinister.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinMinister.Application.Contracts.Persistence
{
    public interface IExpenseRepository : IAsyncRepository<Expense>
    {
        Task<IReadOnlyList<Expense>> GetExpenseListByUserIdAsync(int userId);
    }

}
