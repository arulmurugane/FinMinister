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
    public class IncomeRepository:BaseRepository<Income>, IIncomeRepository
    {
        public IncomeRepository(FinMinisterDbContext dbContext) : base(dbContext)
        {

        }
        public async Task<IReadOnlyList<Income>> GetIncomeListByUserIdAsync(int userId)
        {
            return await _dbContext.Income.Where(e => e.UserId == userId).ToListAsync();
        }
    }
}
