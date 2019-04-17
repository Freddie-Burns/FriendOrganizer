using FriendOrganizer.UI.Event;
using FriendOrganizer.UI.View.Services;
using Prism.Commands;
using Prism.Events;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FriendOrganizer.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IEventAggregator _eventAggregator;
        private IMessageDialogService _messageDialogService;
        private IDetailViewModel _friendDetailViewModel;
        private Func<IFriendDetailViewModel> _friendDetailViewModelCreator;

        public MainViewModel(
            IEventAggregator eventAggregator,
            INavigationViewModel navigationViewModel,
            IMessageDialogService messageDialogService,
            Func<IFriendDetailViewModel> friendDetailViewModelCreator)
        {
            _eventAggregator = eventAggregator;
            _messageDialogService = messageDialogService;
            _friendDetailViewModelCreator = friendDetailViewModelCreator;

            _eventAggregator.GetEvent<OpenDetailViewEvent>()
                .Subscribe(OnOpenDetailView);
            _eventAggregator.GetEvent<AfterDetailDeletedEvent>()
                .Subscribe(AfterDetailDeleted);

            CreateNewFriendCommand = new DelegateCommand(OnCreateNewFriendExecute);

            NavigationViewModel = navigationViewModel;
        }

        public async Task LoadAsync()
        {
            await NavigationViewModel.LoadAsync();
        }

        public ICommand CreateNewFriendCommand { get; }

        public INavigationViewModel NavigationViewModel { get; }

        public IDetailViewModel DetailViewModel
        {
            get { return _friendDetailViewModel; }
            private set
            {
                _friendDetailViewModel = value;
                OnPropertyChanged();
            }
        }

        private async void OnOpenDetailView(OpenDetailViewEventArgs args)
        {
            if (DetailViewModel != null && DetailViewModel.HasChanges)
            {
                var result = _messageDialogService.ShowOKCancelDialog(
                    "You've made changes, navigate away?", 
                    "Question");

                if (result == MessageDialogResult.Cancel)
                {
                    return;
                }
            }

            // If creating new friend.
            if (args == null)
            {
                DetailViewModel = _friendDetailViewModelCreator();
                await DetailViewModel.LoadAsync(null);
                return;
            }

            switch (args.ViewModelName)
            {
                case nameof(FriendDetailViewModel):
                    DetailViewModel = _friendDetailViewModelCreator();
                    break;
            }

            await DetailViewModel.LoadAsync(args.Id);
        }

        private void OnCreateNewFriendExecute()
        {
            OnOpenDetailView(null);
        }

        private void AfterDetailDeleted(AfterDetailDeletedEventArgs args)
        {
            DetailViewModel = null;
        }
    }
}
