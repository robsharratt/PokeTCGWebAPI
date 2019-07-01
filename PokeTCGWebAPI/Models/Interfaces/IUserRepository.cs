using System.Linq;

namespace PokeTCGWebAPI.Models
{
    public class IUserRepository
    {
        IQueryable<User> Users { get; }
    }
}
