using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Data;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;

namespace Ballerz.Football.Ballerz.Services.Service.Implementations
{
    public class StadiumImageService : IStadiumImage
    {
           private readonly ApplicationDbContext _db;
        public StadiumImageService(ApplicationDbContext db)
        {
            _db = db;
        }
          public async Task Create(StadiumImages stadiumImage)
        {
            _db.Add(stadiumImage);
            await _db.SaveChangesAsync();
        }

        public Task Delete(int stadiumImage)
        {
            throw new System.NotImplementedException();
        }

        public Task Edit(int stadiumImage)
        {
            throw new System.NotImplementedException();
        }

          public IEnumerable<StadiumImages> GetAll()
        {
            return _db.StadiumImages.ToList();
        }
    }
}