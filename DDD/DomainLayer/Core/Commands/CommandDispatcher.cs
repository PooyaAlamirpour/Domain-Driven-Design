using System.Threading.Tasks;
using MediatR;

namespace DomainLayer.Core.Commands
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IMediator _mediator;

        public CommandDispatcher(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<bool> Send<T>(T command) where T : Command
        {
            return await _mediator.Send(command);
        }
    }
}