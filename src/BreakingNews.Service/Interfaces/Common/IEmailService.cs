using BreakingNews.Service.Dtos.Common;
namespace BreakingNews.Service.Interfaces.Common;
public interface IEmailService
{
    public Task<bool> SendAsync(EmailMessage emailMessage);
}
