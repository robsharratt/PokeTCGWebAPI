using System.Linq;

namespace PokeTCGWebAPI.Models
{
    public class ITrainerCardRepository
    {
        IQueryable<TrainerCard> TrainerCards { get; }
    }
}
