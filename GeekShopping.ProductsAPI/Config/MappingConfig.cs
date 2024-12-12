using AutoMapper;
using GeekShopping.ProductsAPI.Data.ValueObjects;
using GeekShopping.ProductsAPI.Models;

namespace GeekShopping.ProductsAPI.Config;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mapping = new MapperConfiguration(config => { 
            config.CreateMap<Product, ProductVO>();
            config.CreateMap<ProductVO, Product>(); });
        return mapping;
        //return new(cfg =>
        //{
        //    cfg.CreateMap<Product, ProductVO>()
        //        .ReverseMap();
        //});
    }
}
