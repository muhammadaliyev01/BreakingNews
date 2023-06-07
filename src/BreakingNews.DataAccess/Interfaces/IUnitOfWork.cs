using BreakingNews.DataAccess.Interfaces.News;
using BreakingNews.DataAccess.Interfaces.Users;

namespace BreakingNews.DataAccess.Interfaces;
public interface IUnitOfWork
{
    public INewRepository News { get; }

    public IUserRepository Users { get; }

    public Task<int> SaveChangesAsync();
}
