using Microsoft.AspNetCore.Mvc;
using SupermarketAPIDemo.Domain.Models;
using SupermarketAPIDemo.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupermarketAPIDemo.Controllers
{
    [Route("/api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            return categories;
        }
    }
}