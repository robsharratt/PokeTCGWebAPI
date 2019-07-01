using System.Linq;

namespace PokeTCGWebAPI.Models
{
    public class ISpecialCardRepository
    {
        IQueryable<SpecialCard> SpecialCards { get; }
    }
}
