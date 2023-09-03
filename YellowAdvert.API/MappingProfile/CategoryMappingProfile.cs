using AutoMapper;
using YellowAdvert.API.Dtos.Category.Response;
using YellowAdvert.API.Dtos.Request;
using YellowAdvert.Cqrs.Command;
using YellowAdvert.Cqrs.Query;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.API.MappingProfile
{
    public class CategoryMappingProfile:Profile
    {
        public CategoryMappingProfile()
        {
            GetAllCategoriesResponseMap();
            GetAllCategoriesRequestMap();
            CreateCategoryRequestMap();
        }
        private void GetAllCategoriesResponseMap()
        {
            var map = CreateMap<Category, CategoryResponse>().ReverseMap();  
        }
        private void GetAllCategoriesRequestMap()
        {
            var map = CreateMap<GetAllCategoriesRequest, GetAllCategoriesQuery>().ReverseMap();
        }
        private void CreateCategoryRequestMap()
        {
            var map = CreateMap<CreateCategoryRequest, CreateCategoryCommand>().ReverseMap();
        }
    }
    
}
