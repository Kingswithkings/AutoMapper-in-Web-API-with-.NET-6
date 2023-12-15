using AutoMapper;
using AutoMapper_in_Web_API_with_.NET_6.DTOs;
using AutoMapper_in_Web_API_with_.NET_6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper_in_Web_API_with_.NET_6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionController : ControllerBase
    {
        private IMapper Mapper { get; }
        public ConversionController(IMapper mapper)
        {
            this.Mapper = mapper;
        }
        [HttpPost("FromCategoryDtotoCategoryEntity")]
        public Category PostFromCategoryDtoToCategoryEntity([FromBody] CategoryDto categoryDto)
        {
            return Mapper.Map<Category>(categoryDto);
        }
        [HttpPost("FromCategoryEntityToCategoryDto")]
        public CategoryDto PostFromCategoryEntityToCategoryDto([FromBody] Category categoryEntity)
        {
            return Mapper.Map<CategoryDto>(categoryEntity);
        }
        [HttpPost("FromProductDtoToProductEntity")]
        public Product PostFromProductDtoToProductEntity([FromBody] ProductDto productDto)
        {
            return Mapper.Map<Product>(productDto);
        }
        [HttpPost("FromProductEntityToProductDto")]
        public ProductDto PostFromProductEntityToProductDto([FromBody] Product productEntity)
        {
            return Mapper.Map<ProductDto>(productEntity);
        }

    }
}
