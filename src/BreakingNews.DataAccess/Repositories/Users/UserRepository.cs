using BreakingNews.DataAccess.DbContexts;
using BreakingNews.DataAccess.Interfaces.Users;
using BreakingNews.Domain.Entities.Users;

namespace BreakingNews.DataAccess.Repositories.Users;

public class UserRepository : GenericRepository<User>, IUserRepository 
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }
}
