using Models;

namespace AssignmentDNP2.Data
{
    public interface IUserService
    {
        User validateUser(string userName, string password);
    }
}