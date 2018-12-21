using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEST_test.Models
{
    public class UserOperations
    {
        List<User> usersList = new List<User>();

        protected UserOperations() { }

        private sealed class UserOperationsCreator
        {
            private static readonly UserOperations _usrOps = new UserOperations();
            public static UserOperations UsrOps { get { return _usrOps; } }
        }

        public static UserOperations UsrOps
        {
            get { return UserOperationsCreator.UsrOps; }
        }

        public Task<User> GetUserById(int id)
        {
            return Task.Run(() =>
                (usersList.First(u => u.ID == id))
            );
        }

        public void AddUser(User user)
        {
            if (user == null)
                return;
            if ((usersList.Any(u => u.ID == user.ID)) || (usersList.Any(u => u.Name == user.Name)))
            {
                return;
            }
            else
            {
                usersList.Add(user);
            }
        }

    }
}