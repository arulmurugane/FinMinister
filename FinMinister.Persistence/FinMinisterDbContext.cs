using FinMinister.Domain.Common;
using FinMinister.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinMinister.Persistence
{
    public class FinMinisterDbContext:DbContext
    {
        public FinMinisterDbContext(DbContextOptions<FinMinisterDbContext> options)
           : base(options)
        {
        }

        public DbSet<Expense> Expense { get; set; }
        public DbSet<Income> Income { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = entry.Entity.CreatedDate == null?DateTime.UtcNow: entry.Entity.CreatedDate;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = entry.Entity.LastModifiedDate == null ? DateTime.UtcNow : entry.Entity.LastModifiedDate;
                        break;
                }
            }

            foreach (var entry in ChangeTracker.Entries<SyncAndAuditableEntity>())
            {
                entry.Entity.SyncDateTime = DateTime.UtcNow;
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
