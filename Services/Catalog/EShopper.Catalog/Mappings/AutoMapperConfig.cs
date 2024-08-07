using AutoMapper;
using EShopper.Catalog.Dtos.CategoryDtos;
using EShopper.Catalog.Dtos.FeatureDtos;
using EShopper.Catalog.Dtos.ProductDtos;
using EShopper.Catalog.Entities;

namespace EShopper.Catalog.Mappings
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductDto>().ReverseMap();

            CreateMap<Category, ResultCategoryByIdDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, ResultCategoryDto>().ReverseMap();

            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
        }
    }
}
