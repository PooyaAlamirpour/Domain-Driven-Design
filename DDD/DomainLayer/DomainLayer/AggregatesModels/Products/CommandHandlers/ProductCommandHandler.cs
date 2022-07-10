using System.Threading;
using System.Threading.Tasks;
using DomainLayer.DomainLayer.AggregatesModels.Products.Commands;
using DomainLayer.DomainLayer.AggregatesModels.Products.Repository;
using DomainLayer.DomainLayer.Exceptions;
using DomainLayer.DomainLayer.Models;
using MediatR;

namespace DomainLayer.DomainLayer.AggregatesModels.Products.CommandHandlers
{
    public class ProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
    {
        private readonly IProductRepository _productRepository;

        public ProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                request.InlineValidationResult.Errors.ForEach(x => throw new CustomDomainException(x.ErrorMessage));
                return false;
            }

            var product = new Product(request.Name, request.Code, request.Quantity, request.Cost);
            var existingProduct = _productRepository.FindByName(product);

            return true;
        }
    }
}