using ApplicationLayer.MappingConfigurations;
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
            _mapper = mapper;
            _commandDispatcher = commandDispatcher;
        }

        public void Add(AddNewProductViewModel model)
        {
            var createProductCommand = _mapper.Map<CreateProductCommand>(model);
            _commandDispatcher.Send(createProductCommand);
        }
    }
}