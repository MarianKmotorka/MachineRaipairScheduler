using MachineRepairScheduler.Desktop.Models;
using System.Collections.Generic;

namespace MachineRepairScheduler.Desktop
{
    public class UserComparer : IEqualityComparer<User>
    {
        public bool Equals(User x, User y) => x.UserID == y.UserID;
        public int GetHashCode(User obj) => obj.UserID.GetHashCode();
    }
}
