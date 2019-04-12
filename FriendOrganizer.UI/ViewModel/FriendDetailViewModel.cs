using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModel
{
    public class FriendDetailViewModel : ViewModelBase, IFriendDetailViewModel
    {
        private IFriendDataService _dataService;

        public FriendDetailViewModel(IFriendDataService dataService)
        {
            _dataService = dataService;
        }

        public async Task LoadAsync(int friendId)
        {
            await _dataService.GetAllAsync();
        }

        private Friend _friend;

        public Friend Friend
        {
            get { return _friend; }
            set
            {
                _friend = value;
                OnPropertyChanged();
            }
        }

    }
}
