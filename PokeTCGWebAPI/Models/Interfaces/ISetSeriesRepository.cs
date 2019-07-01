using System.Linq;

namespace PokeTCGWebAPI.Models
{
    public class ISetSeriesRepository
    {
        IQueryable<SetSeries> SetSeries { get; }
    }
}
