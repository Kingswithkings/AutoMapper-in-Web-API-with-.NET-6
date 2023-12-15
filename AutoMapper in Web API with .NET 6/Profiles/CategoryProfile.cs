using AutoMapper;
using AutoMapper_in_Web_API_with_.NET_6.DTOs;
using AutoMapper_in_Web_API_with_.NET_6.Models;

namespace AutoMapper_in_Web_API_with_.NET_6.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDto, Category>().ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Name)).ForMember(dest => dest.CategoryId, opt => opt.Ignore());
            CreateMap<Category, CategoryDto>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CategoryName));
        }
    
    }
}
