using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Data;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;

namespace Ballerz.Football.Ballerz.Services.Service.Implementations
{
    public class ClubPersonService : IClubPerson
    {
        private readonly ApplicationDbContext _db;

        public ClubPersonService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(ClubPerson clubPerson)
        {
              _db.Add(clubPerson);
            await _db.SaveChangesAsync();
        }

        public Task Delete(int playersId)
        {
            throw new System.NotImplementedException();
        }

        public Task Edit(int clubPersonId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ClubPerson> GetAll()
        {
            return _db.ClubPeople.ToList();
        }

        public IEnumerable<ClubPerson> GetByClubId(int id)
        {
            return _db.ClubPeople.Where(c => c.ClubId == id).ToList();
        }

        public IEnumerable<ClubPerson> GetByCountryId(int id)
        {
            return _db.ClubPeople.Where(c => c.CountryId == id).ToList();
        }

        public ClubPerson GetById(int? id)
        {
            return _db.ClubPeople.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}