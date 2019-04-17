using FriendOrganizer.Model;
using FriendOrganizer.UI.Wrapper;

namespace FriendOrganizer.UI.ViewModel
{
    public class FriendPhoneNumberWrapper : ModelWrapper<FriendPhoneNumber>
    {
        public FriendPhoneNumberWrapper(FriendPhoneNumber model) : base(model)
        {
        }

        public int Id { get { return Model.Id; } }

        public string Number {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public int FriendId
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public Friend Friend
        {
            get { return GetValue<Friend>(); }
            set { SetValue(value); }
        }
    }
}