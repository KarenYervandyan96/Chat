using ChatApp.Entity;

namespace ChatApp.Repository
{
    public interface IMessageRepository
    {
        Task CreatMessage(ChatEntity entity);
        Task<IEnumerable<ChatEntity>> GetAllMessage();
        Task<ChatEntity> GetAllMessageByID(Guid id);
    }
}