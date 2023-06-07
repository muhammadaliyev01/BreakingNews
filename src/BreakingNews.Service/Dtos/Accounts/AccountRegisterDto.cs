using BreakingNews.Domain.Entities.Users;
using BreakingNews.Service.Common.Attributes;
using System.ComponentModel.DataAnnotations;

namespace BreakingNews.Service.Dtos.Accounts;
public class AccountRegisterDto : AccountLoginDto
{
    [Required(ErrorMessage = "Ismingizni kiriting!")]
    public string FirstName { get; set; } = String.Empty;

    [Required(ErrorMessage = "familiyangizni kiriting!")]
    public string LastName { get; set; } = String.Empty;

    [Required(ErrorMessage = "Telefon raqamingizni kiriting!")]
    [PhoneNumber]
    public string PhoneNumber { get; set; } = String.Empty;

    public static implicit operator User(AccountRegisterDto accountRegisterDto)
    {
        return new User()
        {
            FirstName = accountRegisterDto.FirstName,
            LastName = accountRegisterDto.LastName,
            Email = accountRegisterDto.Email,
            PhoneNumber = accountRegisterDto.PhoneNumber,
            
        };
    }
}
