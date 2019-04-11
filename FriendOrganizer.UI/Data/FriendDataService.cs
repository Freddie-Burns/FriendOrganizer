using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;
using System.Collections.Generic;
using System.Linq;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            using(var ctx = new FriendOrganizerDbContext())
            {
                return ctx.Friends.AsNoTracking().ToList();
            }
        }
    }
}
