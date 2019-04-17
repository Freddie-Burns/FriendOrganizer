using FriendOrganizer.UI.Data.Lookups;
using FriendOrganizer.UI.Event;
using Prism.Events;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModel
{
    public class NavigationViewModel : ViewModelBase, INavigationViewModel
    {
        private IFriendLookupDataService _friendLookupService;
        private IEventAggregator _eventAggregator;

        public NavigationViewModel(
            IFriendLookupDataService friendLookupService,
            IEventAggregator eventAggregator)
        {
            _friendLookupService = friendLookupService;
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<AfterFriendSavedEvent>().Subscribe(AfterFriendSaved);
            _eventAggregator.GetEvent<AfterFriendDeletedEvent>().Subscribe(AfterFriendDeleted);

            Friends = new ObservableCollection<NavigationItemViewModel>();
        }

        public async Task LoadAsync()
        {
            var lookup = await _friendLookupService.GetFriendLookupAsync();
            Friends.Clear();
            foreach (var item in lookup)
            {
                Friends.Add(new NavigationItemViewModel(
                    item.Id, 
                    item.DisplayMember, 
                    nameof(FriendDetailViewModel),
                    _eventAggregator));
            }
        }

        public ObservableCollection<NavigationItemViewModel> Friends { get; }

        private void AfterFriendSaved(AfterFriendSavedEventArgs obj)
        {
            NavigationItemViewModel lookupItem = Friends.SingleOrDefault(l => l.Id == obj.Id);
            if (lookupItem == null)
            {
                Friends.Add(new NavigationItemViewModel(
                    obj.Id,
                    obj.DisplayMember,
                    nameof(FriendDetailViewModel),
                    _eventAggregator));
            }
            else
            {
                lookupItem.DisplayMember = obj.DisplayMember;
            }
        }

        private void AfterFriendDeleted(int friendId)
        {
            NavigationItemViewModel friend = Friends.SingleOrDefault(l => l.Id == friendId);
            if (friend != null)
            {
                Friends.Remove(friend);
            }
        }
    }
}
