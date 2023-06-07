using BreakingNews.Domain.Common;
using System.Linq.Expressions;

namespace BreakingNews.DataAccess.Interfaces;

public interface IRepository<T> where T : BaseEntity
{
    public Task<T?> FindByIdAsync(long id);

    public Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression);

    public void Add(T entity);

    public void Delete(long id);

    public void Update(long id, T entity);
}
