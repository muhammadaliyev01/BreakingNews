using BreakingNews.Domain.Common;

namespace BreakingNews.Domain.Entities.New
{
    public class New : BaseEntity 
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ImagePath { get; set; } = string.Empty;

        public DateTime CreateAt { get; set; }
    }
}
