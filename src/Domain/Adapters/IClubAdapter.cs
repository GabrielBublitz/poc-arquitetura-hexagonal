
using Domain.Entities;

namespace Domain.Adapters
{
    public interface IClubAdapter
    {
        public Task<IEnumerable<Club>> GetAll();

        public Task<int> Insert(Club club);
    }
}
