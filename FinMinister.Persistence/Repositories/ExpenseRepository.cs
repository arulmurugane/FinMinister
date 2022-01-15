using FinMinister.Application.Contracts.Persistence;
using FinMinister.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinMinister.Persistence.Repositories
{
    public class ExpenseRepository: BaseRepository<Expense>, IExpenseRepository
    {
        public ExpenseRepository(FinMinisterDbContext dbContext):base(dbContext)
        {

        }
        public async Task<IReadOnlyList<Expense>> GetExpenseListByUserIdAsync(int userId)
        {
            return await _dbContext.Expense.Where(e => e.UserId == userId).ToListAsync();
        }
    }
}
