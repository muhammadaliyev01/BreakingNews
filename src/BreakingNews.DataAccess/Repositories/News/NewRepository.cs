using BreakingNews.DataAccess.DbContexts;
using BreakingNews.DataAccess.Interfaces.News;
using BreakingNews.Domain.Entities.New;

namespace BreakingNews.DataAccess.Repositories.News;

public class NewRepository : GenericRepository<New>, INewRepository
{
    public NewRepository(AppDbContext context) : base(context)
    {
    }
}
