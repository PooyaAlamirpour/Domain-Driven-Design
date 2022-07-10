using ApplicationLayer.Models;
using AutoMapper;
using DomainLayer.Core.Commands;
using DomainLayer.DomainLayer.AggregatesModels.Products.Commands;

namespace ApplicationLayer.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly ICommandDispatcher _commandDispatcher;

        public ProductService(IMapper mapper, ICommandDispatcher commandDispatcher)
        {
            var configuration = new MapperConfiguration(cfg => {
                cfg.CreateMap<CreateProductCommand, AddNewProductViewModel>().ReverseMap();
            });
            _mapper = configuration.CreateMapper();
            _commandDispatcher = commandDispatcher;
        }

        public void Add(AddNewProductViewModel model)
        {
            var createProductCommand = _mapper.Map<CreateProductCommand>(model);
            _commandDispatcher.Send(createProductCommand);
        }
    }
}