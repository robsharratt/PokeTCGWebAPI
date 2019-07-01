using System.Collections.Generic;
using System.Linq;

namespace PokeTCGWebAPI.Models
{
    public class EFUserRepository : ICardRepository
    {
        private ApplicationDbContext context;

        public EFUserRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<User> User => context.Users;
    }
}
