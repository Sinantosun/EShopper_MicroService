using AutoMapper;
using EShopper.Catalog.Dtos.CategoryDtos;
using EShopper.Catalog.Entities;
using EShopper.Catalog.Services.CategoryServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static MongoDB.Driver.WriteConcern;

namespace EShopper.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var values = await _categoryService.GetAllAsync();
            var mappedValue = _mapper.Map<List<ResultCategoryDto>>(values);
            return Ok(mappedValue);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(string id)
        {
            var value = await _categoryService.GetByIdAsync(id);
            var mappedValue = _mapper.Map<ResultCategoryByIdDto>(value);
            return Ok(mappedValue);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var category = _mapper.Map<Category>(createCategoryDto);
            await _categoryService.CreateAsync(category);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var category = _mapper.Map<Category>(updateCategoryDto);
            await _categoryService.UpdateAsync(category);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(string id)
        {
            await _categoryService.RemoveAsync(id);
            return Ok();
        }
    }
}
