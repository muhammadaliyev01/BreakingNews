using BreakingNews.Domain.Entities.Users;

namespace BreakingNews.Service.Interfaces.Common;
public interface IAuthService
{
    public string GenerateToken(User user);
}
