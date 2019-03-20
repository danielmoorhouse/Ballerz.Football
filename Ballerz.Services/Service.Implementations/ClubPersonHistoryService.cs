using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Data;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;

namespace Ballerz.Football.Ballerz.Services.Service.Implementations
{
    public class ClubPersonHistoryService : IClubPersonHistory
    {
             private readonly ApplicationDbContext _db;
        public ClubPersonHistoryService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(ClubPersonHistory clubPersonHistory)
        {
             _db.Add(clubPersonHistory);
            await _db.SaveChangesAsync();
        }

        public IEnumerable<ClubPersonHistory> GetAll()
        {
            return _db.ClubPersonHistory.ToList();
        }
    }
}