using BreakingNews.DataAccess.Interfaces;
using BreakingNews.Domain.Entities.New;
using BreakingNews.Service.Common.Utils;
using BreakingNews.Service.Interfaces.Products;
using BreakingNews.Service.ViewModels.Products;
using Microsoft.EntityFrameworkCore;
using SendGrid.Helpers.Errors.Model;

namespace BreakingNews.Service.Services.Products;
public class NewService : INewService
{
    private readonly IUnitOfWork _repository;
    public NewService(IUnitOfWork unitOfWork)
    {
        this._repository = unitOfWork;
    }

    public async Task<bool> CreateAsync(NewViewModel viewModel)
    {
        New @news = new New()
        {
            Name=viewModel.Name,
            Description=viewModel.Description,
            CreateAt=viewModel.DateTime,
            ImagePath=viewModel.ImagePath,
        };
        _repository.News.Add(@news);
        return true;
    }

    public async Task<IEnumerable<NewBaseViewModel>> GetAllAsync(PaginationParams @params)
    {
        var query = _repository.News.GetAll().OrderBy(x => x.CreateAt);
        var resalt= from news in query
               select new NewBaseViewModel()
               {
                   Id = news.Id,
                   Name = news.Name,
                   ImagePath = news.ImagePath,
               };
        return resalt.ToList();
    }

    public async Task<NewViewModel> GetAsync(long productId)
    {
        var @new = await _repository.News.GetAll().FirstOrDefaultAsync(product=>product.Id==productId);
        if (@new is null) throw new NotFoundException("Ushbu id bilan maxsulot topilmadi!");

        return new NewViewModel()
        {
            Id = @new.Id,
            Name = @new.Name,
            ImagePath = @new.ImagePath,
            Description = @new.Description,
            DateTime = @new.CreateAt,
        };
    }
}
