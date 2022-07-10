using ApplicationLayer.Models;
using AutoMapper;
using DomainLayer.DomainLayer.AggregatesModels.Products.Commands;

namespace ApplicationLayer.MappingConfigurations
{
    public class MappingViewModelToCommandProfile : Profile
    {
        public MappingViewModelToCommandProfile()
        {
            CreateMap<AddNewProductViewModel, CreateProductCommand>()
                .ConstructUsing(x => new CreateProductCommand(x.Name, x.Code, x.Quantity, x.Cost));
        }
    }
}