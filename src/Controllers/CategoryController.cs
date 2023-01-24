using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using dws_ex_1.src.Domain.Models;
using dws_ex_1.src.Domain.Services.IServices;
using dws_ex_1.src.Resources;
using dws_ex_1.src.Mapping;

namespace dws_ex_1.src.Controllers
{
    [Route("/src/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryResource>>(
                categories
            );

            return resources;
        }
    }
}
