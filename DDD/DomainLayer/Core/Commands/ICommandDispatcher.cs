using System.Threading.Tasks;

namespace DomainLayer.Core.Commands
{
    public interface ICommandDispatcher
    {
        Task<bool> Send<T>(T command) where T : Command;
    }
}