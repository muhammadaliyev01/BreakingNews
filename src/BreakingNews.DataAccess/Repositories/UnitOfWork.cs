using BreakingNews.DataAccess.DbContexts;
using BreakingNews.DataAccess.Interfaces;
using BreakingNews.DataAccess.Interfaces.News;
using BreakingNews.DataAccess.Interfaces.Users;
using BreakingNews.DataAccess.Repositories.News;
using BreakingNews.DataAccess.Repositories.Users;

namespace BreakingNews.DataAccess.Repositories;
public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext dbContext;
        
    public INewRepository News { get;  }
    public IUserRepository Users { get; }

    public UnitOfWork(AppDbContext appDbContext)
    {
        this.dbContext = appDbContext;

        News = new NewRepository(appDbContext);

        Users = new UserRepository(appDbContext);
    }

    public async Task<int> SaveChangesAsync()
    {
        return await dbContext.SaveChangesAsync();
    }
}
