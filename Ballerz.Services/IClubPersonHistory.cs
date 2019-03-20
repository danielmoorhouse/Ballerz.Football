using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;

namespace Ballerz.Football.Ballerz.Services
{
    public interface IClubPersonHistory
    {
          Task Create(ClubPersonHistory clubPersonHistory); 
        IEnumerable<ClubPersonHistory> GetAll();  
    }
}