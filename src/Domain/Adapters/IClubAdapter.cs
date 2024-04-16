
using Api.Entities;

namespace Api.Adapters
{
    public interface IClubAdapter
    {
        public Task<IEnumerable<Club>> GetAll();

        public Task<int> Insert(Club club);
    }
}
