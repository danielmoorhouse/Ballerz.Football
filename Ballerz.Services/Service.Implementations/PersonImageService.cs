using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Data;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;

namespace Ballerz.Football.Ballerz.Services.Service.Implementations
{
    public class PersonImageService : IPersonImage
    {
         private readonly ApplicationDbContext _db;
        public PersonImageService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(ClubPersonImages personImage)
        {
            _db.Add(personImage);
            await _db.SaveChangesAsync();
        }

        public Task Delete(int personImage)
        {
            throw new System.NotImplementedException();
        }

        public Task Edit(int personImage)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ClubPersonImages> GetAll()
        {
            return _db.ClubPersonImages.ToList();
        }
    }
}