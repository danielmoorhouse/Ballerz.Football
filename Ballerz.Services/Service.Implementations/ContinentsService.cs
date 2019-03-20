using System.Collections.Generic;
using System.Linq;
using Ballerz.Football.Ballerz.Data;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;

namespace Ballerz.Football.Ballerz.Services.Service.Implementations
{
    public class ContinentsService : IContinent
    {
         private readonly ApplicationDbContext _db;
        public ContinentsService(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Continents> GetAll()
        {
            return _db.Continents.ToList();
        }
    }
}