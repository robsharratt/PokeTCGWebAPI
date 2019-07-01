using System.Collections.Generic;
using System.Linq;

namespace PokeTCGWebAPI.Models
{
    public class EFSpecialCardRepository : ISpecialCardRepository
    {
        private ApplicationDbContext context;

        public EFSpecialCardRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<SpecialCard> SpecialCard => context.SpecialCards;
    }
}
