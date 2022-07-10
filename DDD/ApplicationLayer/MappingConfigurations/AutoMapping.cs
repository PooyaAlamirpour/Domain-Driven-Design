using AutoMapper;

namespace ApplicationLayer.MappingConfigurations
{
    public class AutoMapping
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingViewModelToCommandProfile());
            });
        }
    }
}