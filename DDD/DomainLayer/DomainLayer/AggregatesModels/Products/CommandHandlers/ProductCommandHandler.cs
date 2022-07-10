using System.Threading;
using System.Threading.Tasks;
using DomainLayer.DomainLayer.AggregatesModels.Products.Commands;
using DomainLayer.DomainLayer.Exceptions;
using MediatR;

namespace DomainLayer.DomainLayer.AggregatesModels.Products.CommandHandlers
{
    public class ProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
    {
        public async Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                request.InlineValidationResult.Errors.ForEach(x => throw new CustomDomainException(x.ErrorMessage));
                return false;
            }
            
            

            return true;
        }
    }
}