using Messenger.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Messenger.Interface
{
    public interface IChatService
    {
        Task CreatMessage(CreatMessage messageITem);
        Task<IEnumerable<MessageITem>> GetAllMessageAsync();
    }
}