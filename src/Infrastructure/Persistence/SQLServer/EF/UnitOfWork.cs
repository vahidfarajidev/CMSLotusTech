using Domain.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EFDbContext _efDbContext;

        public UnitOfWork(EFDbContext efDbContext)
        {
            _efDbContext = efDbContext ?? throw new ArgumentNullException(nameof(efDbContext));
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return _efDbContext.SaveChangesAsync(cancellationToken);
        }

        public void Dispose() => _efDbContext.Dispose();
    }

}
