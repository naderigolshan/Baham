using Microsoft.EntityFrameworkCore;

namespace Baham.DataLayer.Context;

public interface IUnitOfWork : IDisposable
{
    Task<int> SaveChangesAsync();
    int SaveChanges();
    void MarkAsDeleted<TEntity>(TEntity entity);
    DbSet<TEntity> Set<TEntity>() where TEntity : class;

}
