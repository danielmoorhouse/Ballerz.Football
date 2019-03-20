using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Data;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;

namespace Ballerz.Football.Ballerz.Services.Service.Implementations
{
    public class ClubRoleService : IClubRole
    {
           private readonly ApplicationDbContext _db;
        public ClubRoleService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(ClubRole clubRole)
        {
            _db.Add(clubRole);
            await _db.SaveChangesAsync();
        }

        public Task Delete(int clubRoleId)
        {
            throw new System.NotImplementedException();
        }

        public Task Edit(int clubRoleId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ClubRole> GetAll()
        {
            return _db.ClubRoles.ToList();
        }

        public Task<ClubRole> GetByClubName(string clubRole)
        {
            throw new System.NotImplementedException();
        }

        public List<ClubRole> GetByCompetitionId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}