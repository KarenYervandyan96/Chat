using ChatApp.Entity;
using MongoDB.Driver;

namespace ChatApp.Repository
{
    public class MessageRepository : IMessageRepository
    {
        private const string connectionString = "mongodb://localhost:27017";
        private const string database = "Chat";
        private IMongoCollection<ChatEntity> _collection;
        public MessageRepository()
        {
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(database);
            _collection = db.GetCollection<ChatEntity>("chat");

        }
        private FilterDefinitionBuilder<ChatEntity> FilterDefinitionBuilder = new FilterDefinitionBuilder<ChatEntity>();

        public async Task<IEnumerable<ChatEntity>> GetAllMessage()
        {
            var filter = FilterDefinitionBuilder.Empty;
            var data = await _collection.FindAsync(filter);
            return await data.ToListAsync();
        }
        public async Task<ChatEntity> GetAllMessageByID(Guid id)
        {
            var filter = FilterDefinitionBuilder.Eq(p => p.id, id);
            var data = await _collection.FindAsync(filter);
            return await data.SingleOrDefaultAsync();
        }

        public async Task CreatMessage(ChatEntity entity)
        {
            //var filter = FilterDefinitionBuilder.Eq(p => p.ID,entity.ID);
            await _collection.InsertOneAsync(entity);
            await Task.CompletedTask;
        }
    }
}
