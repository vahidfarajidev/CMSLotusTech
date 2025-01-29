using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EFDbContext _eFDbContext;

        public UnitOfWork(EFDbContext eFDbContext)
        {
            _eFDbContext = eFDbContext ?? throw new ArgumentNullException(nameof(eFDbContext));
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return _eFDbContext.SaveChangesAsync(cancellationToken);
        }

        public void Dispose() => _eFDbContext.Dispose();
    }

}
