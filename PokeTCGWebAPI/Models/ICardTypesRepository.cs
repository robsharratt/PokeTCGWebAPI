using System.Linq;

namespace PokeTCGWebAPI.Models
{
    public class ICardTypeRepository
    {
        IQueryable<CardType> CardTypes { get; }
    }
}
