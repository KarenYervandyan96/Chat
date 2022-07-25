using Messenger.Interface;
using Messenger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Implementation
{
    public class ChatService : IChatService
    {

        HttpClient client = new HttpClient();
        public ChatService()
        {
            client.BaseAddress = new Uri("https://localhost:7250/");
        }
        public async Task<IEnumerable<MessageITem>> GetAllMessageAsync()
        {
            var masseg = await client.GetAsync("chat");
            if (masseg.IsSuccessStatusCode)
            {
                return await masseg.Content.ReadFromJsonAsync<IEnumerable<MessageITem>>();
            }
            return Enumerable.Empty<MessageITem>();

        }
        public async Task CreatMessage(CreatMessage messageITem)
        {
            await client.PostAsJsonAsync<CreatMessage>($"https://localhost:7250/chat", new CreatMessage(messageITem.id, messageITem.Name, messageITem.Message));
         
        }
    }
}
