using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Baham.Entities;


namespace Baham.DataLayer.Context;

public class BahamDbContext : IdentityDbContext<User, Role, int>, IUnitOfWork
{
    public BahamDbContext(DbContextOptions options) : base(options)
    {
    }

    public Task<int> SaveChangesAsync() => base.SaveChangesAsync();
    public void MarkAsDeleted<TEntity>(TEntity entity) => base.Entry(entity).State = EntityState.Deleted;


    // public DbSet<StoreCategory> StoreCategories { get; set; }
    // public DbSet<Store> Stores { get; set; }
}
