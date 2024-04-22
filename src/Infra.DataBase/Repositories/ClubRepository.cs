using Domain.Adapters;
using Domain.Entities;

namespace Infra.DataBase.Repositories
{
    public class ClubRepository : IClubAdapter
    {
        public ClubRepository() { }

        public Task<IEnumerable<Club>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> Insert(Club club)
        {
            throw new NotImplementedException();
        }
    }
}
