using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;

namespace Ballerz.Football.Ballerz.Services
{
    public interface IClubPerson
    {
         ClubPerson GetById(int? id);
         IEnumerable<ClubPerson> GetByClubId(int id);
         IEnumerable<ClubPerson> GetByCountryId(int id);
         IEnumerable<ClubPerson> GetAll();

         Task Create(ClubPerson clubPerson);
         Task Edit(int clubPersonId); 
         Task Delete(int playersId);
    }
}