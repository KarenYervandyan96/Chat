using MyMessenger.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyMessenger.Interface
{
    internal interface ICharService
    {
        Task CreatMessage(CreatMessage messageITem);
        Task<IEnumerable<MessageITem>> GetAllMessageAsync();
    }
}