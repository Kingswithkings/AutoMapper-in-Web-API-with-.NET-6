namespace AutoMapper_in_Web_API_with_.NET_6.DTOs
{
    public class CategoryDto
    {
        public CategoryDto()
        {
            Products = new HashSet<ProductDto>();
        }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public virtual ICollection<ProductDto> Products { get; set; }

    }
}
