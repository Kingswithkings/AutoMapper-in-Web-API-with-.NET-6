using AutoMapper;
using AutoMapper_in_Web_API_with_.NET_6.DTOs;
using AutoMapper_in_Web_API_with_.NET_6.Models;

namespace AutoMapper_in_Web_API_with_.NET_6.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile() {
            CreateMap < ProductDto, Product > ().ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Name)).ForMember(dest => dest.ProductId, opt => opt.Ignore());
            CreateMap<Product, ProductDto>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ProductName));
        }
    }
}
