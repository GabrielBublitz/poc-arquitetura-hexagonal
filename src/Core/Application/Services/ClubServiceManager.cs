using Domain.Adapters;
using Domain.Entities;
using Domain.Services;

namespace Application
{
    public class ClubServiceManager(IClubAdapter clubRepository, IEmailAdapter emailAdapter) : IClubService
    {
        private IEmailAdapter EmailAdapter { get; set; } = emailAdapter;

        private IClubAdapter ClubRepository { get; set; } = clubRepository;

        public async Task<IEnumerable<Club>> RecoverAllClubs()
        {
            var clubs = await ClubRepository.GetAll();
            return clubs;
        }

        public async Task<int> RegisterClub(Club club)
        {
            var id = await ClubRepository.Insert(club);

            _ = EmailAdapter.SendEmail("", "", "", "");

            return id;
        }
    }
}
