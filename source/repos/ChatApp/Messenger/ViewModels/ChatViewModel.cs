using Messenger.Implementation;
using Messenger.Interface;
using Messenger.Model;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Messenger.ViewModels
{
    public class ChatViewModel
    {

        public Guid id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        private IChatService chatService;
        public ChatViewModel()
        {

        }
        public ICommand add;
        public ICommand Add
        {
            get { return add ?? (add = new DelegateCommand(() => AddCommand())); }
        }
        public void AddCommand()
        {
            chatService.CreatMessage(new CreatMessage(this.id, this.Name, this.Message));
        }

        public ChatViewModel(Guid id,string Name, string Message, ChatService chatService) 
        {
            this.Name = Name;
            this.Message = Message;
            this.id = id;
            this.chatService = chatService;
           

        }

    MessageITem ConvertToDto()
        {
            return new MessageITem(this.id, this.Name, this.Message);
        }
    }
}
