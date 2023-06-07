using BreakingNews.Service.Dtos.Accounts;
namespace BreakingNews.Service.Interfaces.Accounts;
public interface IAccountService
{
    public Task<bool> RegisterAsync(AccountRegisterDto accountRegisterDto);

    public Task<string> LoginAsync(AccountLoginDto accountLoginDto);
}
