using BreakingNews.Service.Common.Utils;
using BreakingNews.Service.ViewModels.Products;

namespace BreakingNews.Service.Interfaces.Products;
public interface INewService
{
    public Task<IEnumerable<NewBaseViewModel>> GetAllAsync(PaginationParams @params);

    public Task<NewViewModel> GetAsync(long productId);

    public Task<bool> CreateAsync(NewViewModel viewModel);
}
