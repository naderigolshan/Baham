using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Baham.Entities;
using Baham.Entities.Identity;
using Baham.ViewModels.Application;

namespace Baham.DataLayer.Context;

public class BahamDbContext :
    IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>,
    IUnitOfWork
{
    public BahamDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

    public Task<int> SaveChangesAsync() => base.SaveChangesAsync();
    public void MarkAsDeleted<TEntity>(TEntity entity) => base.Entry(entity).State = EntityState.Deleted;


    public DbSet<StoreCategory> StoreCategories { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemCategory> ItemCategories { get; set; }
    public DbSet<ProductItemValue> ProductItemValues { get; set; }
    public DbSet<Province> Provinces { get; set; }
    public DbSet<Township> Townships { get; set; }
    public DbSet<StoreAddress> StoreAddresses { get; set; }
}
