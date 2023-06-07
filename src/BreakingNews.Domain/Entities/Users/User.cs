using BreakingNews.Domain.Common;

namespace BreakingNews.Domain.Entities.Users
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }=string.Empty;

        public string LastName { get; set; }= string.Empty;

        public string PhoneNumber { get; set; }=string.Empty;

        public string Email { get; set; }=string.Empty;
        public string PasswordHash { get; set; } = String.Empty;

        public bool IsAdmin { get; set; }

        public string Salt { get; set; } = String.Empty;

        public DateTime DateTime { get; set; }
    }
}
