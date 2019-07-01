using System.Linq;

namespace PokeTCGWebAPI.Models
{
    public class ICardRepository
    {
        IQueryable<Card> Cards { get; }
    }
}
