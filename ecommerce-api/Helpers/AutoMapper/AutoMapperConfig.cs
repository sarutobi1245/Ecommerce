using ecommerce_api.Helpers.AutoMapper;
using AutoMapper;

namespace ecommerce_api.Helpers.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new EfToDtoMappingProfile());
                cfg.AddProfile(new DtoToEfMappingProfile());
            });
        }
    }
}