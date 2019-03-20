using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;

namespace Ballerz.Football.Ballerz.Services
{
    public interface IClubRole
    {
        IEnumerable<ClubRole> GetAll(); 
         Task<ClubRole> GetByClubName(string clubRole);
         List<ClubRole> GetByCompetitionId(int id);
         Task Create(ClubRole clubRole);
         Task Edit(int clubRoleId);
         Task Delete(int clubRoleId); 
    }
}