using Microsoft.AspNetCore.Mvc;
using dws_ex_1.src.Domain.Models;
using dws_ex_1.src.Domain.Services.IServices;

namespace dws_ex_1.src.Controllers {
    
    [Route("/src/[controller]")]
    public class CategoryController : Controller {
        private readonly ICategoryService _categoryService;
    
        public CategoryController(ICategoryService categoryService) {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllAsync() {
            var categories = await _categoryService.ListAsync();

            return categories;
        }
    }
        
}