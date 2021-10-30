using Models;
using System.Threading.Tasks;

namespace AssignmentDNP2.Data
{
    public interface IUserLogin
    {
        Task<User> ValidateUser(string userName);
    }
}