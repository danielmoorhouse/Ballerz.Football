using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Data;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;

namespace Ballerz.Football.Ballerz.Services.Service.Implementations
{
    public class SeasonsService : ISeason
    {
           private readonly ApplicationDbContext _db;
        public SeasonsService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(Seasons seasons)
        {
             _db.Add(seasons);
            await _db.SaveChangesAsync();
        }
        public IEnumerable<Seasons> GetAll()
        {
            return _db.Seasons.ToList();
        }
    }
}