using BreakingNews.Service.Common.Utils;
using BreakingNews.Service.Interfaces.Products;
using BreakingNews.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BreakingNews.Web.Controllers;

[Route("news")]
//[Authorize]
public class NewsController : Controller
{
    private readonly INewService _newService;
    private readonly int _pageSize = 30;
    public NewsController(INewService newService)
    {
        this._newService = newService;
    }
    public async Task<IActionResult> Index(int page = 1)
    {
        var products = await _newService.GetAllAsync(new PaginationParams(page, _pageSize));
        return View("Index", products);
    }

    [HttpGet("{productId}")]
    public async Task<ViewResult> GetAsync(long productId)
    {
        var product = await _newService.GetAsync(productId);
        return View(product);
    }
}
