
using Models;

using System.Threading.Tasks;
using FileData;


namespace AssignmentDNP2.Data
{
    public class UserLogin : IUserLogin 
    {
        public async Task<User> ValidateUser(string username)
        {
            FileContext fileContext = new FileContext();
            {
                foreach (User user in fileContext.Users)
                {
                    if (user.UserName.Equals(username))
                    {
                        return user;
                    }
                }

                return null;

            }
        }
    }
}