using Messenger.Implementation;
using Messenger.Model;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Messenger.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        private ChatService ChatService;
        private IEnumerable<ChatViewModel> items;
        private ChatViewModel selectedProduct;
        public ChatViewModel SelectedProduct
        {
            get => selectedProduct;
            set
            {
                SetProperty(ref selectedProduct, value);
                RaisePropertyChanged(nameof(selectedProduct));
            }
        }
        public IEnumerable<ChatViewModel> Items { get => items; set => SetProperty(ref items, value); }
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public ICommand but;
        public ICommand But
        {
            get { return but ?? (but = new DelegateCommand(() => AddCommand())); }
        }
        public void AddCommand()
        {
            ChatService.CreatMessage(new CreatMessage(selectedProduct.id, selectedProduct.Name, selectedProduct.Message));
        }

        public ICommand refresh;
        public ICommand Refresh
        {
            get { return refresh ?? (refresh = new DelegateCommand(async () => await Refreshlist())); }
        }
        private async Task Refreshlist()
        {
            InitViewModel();
        }

        internal async Task InitViewModel()
        {
            var list = (await ChatService.GetAllMessageAsync()).Select(p => new ChatViewModel(p.Id,p.Name, p.Message, ChatService));
            Items = list;
        }
      

        public MainWindowViewModel()
        {

        }
        public MainWindowViewModel(ChatService carService,ChatViewModel chatViewModel)
        {
            this.ChatService = carService;
            this.selectedProduct = chatViewModel;
        }

    }
}
