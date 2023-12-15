namespace AutoMapper_in_Web_API_with_.NET_6.DTOs
{
    public class ProductDto
    {
        public ProductDto() { }
        public string Name { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set;}  
        public short? UnitsPrice { get; set;}
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }    
        public short? ReorderLevel { get; set; }   
        public bool Discontinued { get; set;}
        public virtual CategoryDto ? Category { get; set; } 

    }
}
