using BreakingNews.Domain.Entities.New;
using BreakingNews.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;


namespace BreakingNews.DataAccess.DbContexts;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; } = default!;
    public virtual DbSet<New> News { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
