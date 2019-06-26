using System.Linq;

namespace PokeTCGWebAPI.Models
{
    public class ISetRepository
    {
        IQueryable<Set> Sets { get; }
    }
}
