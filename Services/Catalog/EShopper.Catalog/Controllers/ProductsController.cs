using AutoMapper;
using EShopper.Catalog.Dtos.ProductDtos;
using EShopper.Catalog.Entities;
using EShopper.Catalog.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace EShopper.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var values = await _productService.GetAllAsync();
            var mappedValue = _mapper.Map<List<ResultProductDto>>(values);
            return Ok(mappedValue);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(string id)
        {
            var value = await _productService.GetByIdAsync(id);
            var mappedValue = _mapper.Map<ResultProductByIdDto>(value);
            return Ok(mappedValue);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            var Product = _mapper.Map<Product>(createProductDto);
            await _productService.CreateAsync(Product);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            var Product = _mapper.Map<Product>(updateProductDto);
            await _productService.UpdateAsync(Product);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.RemoveAsync(id);
            return Ok();
        }
        [HttpGet("GetProductsByCategory/{categoryName}")]
        public async Task<IActionResult> GetProductsByCategory(string categoryName)
        {
            var values = await _productService.GetFilteredListAsync(x=>x.CategoryName == categoryName);
            return Ok(values);
        }
    }
}
