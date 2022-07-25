using Chat.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Service
{
    //internal class ChatService : IChatService
    //{
    //    HttpClient client = new HttpClient();
    //    public ChatService()
    //    {
    //        client.BaseAddress = new Uri("https://localhost:7250/");
    //    }
    //    public async Task<IEnumerable<MessageITem>> GetAllMessageAsync()
    //    {
    //        var masseg = await client.GetAsync("chat");
    //        if (masseg.IsSuccessStatusCode)
    //        {
    //            return await masseg.Content.ReadFromJsonAsync<IEnumerable<MessageITem>>();
    //        }
    //        return Enumerable.Empty<MessageITem>();

    //    }
    //    public async Task CreatMessage(CreatMessage messageITem)
    //    {
    //        await client.PostAsJsonAsync<CreatMessage>($"https://localhost:7250/chat", new CreatMessage(messageITem.Name, messageITem.Message));
    //        GetAllMessageAsync();
    //    }

      
        
    //}
}
