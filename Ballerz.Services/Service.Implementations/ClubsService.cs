using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Data;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;

namespace Ballerz.Football.Ballerz.Services.Service.Implementations
{
    public class ClubsService : IClubs
    {
                private readonly ApplicationDbContext _db;
        public ClubsService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(Club club)
        {
                _db.Add(club);
            await _db.SaveChangesAsync();
        }

        public Task Delete(int clubId)
        {
            throw new System.NotImplementedException();
        }

        public Task Edit(int clubId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Club> GetAll()
        {
            return _db.Clubs.ToList();
        }

        public Club GetById(int id)
        {
            return _db.Clubs.Where(t => t.Id == id).FirstOrDefault();
        }

        public List<Club> GetByCompetitionId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Club> GetByClubName(string clubName)
        {
            throw new System.NotImplementedException();
        }
        
    }
}