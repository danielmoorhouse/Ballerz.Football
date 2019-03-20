using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;

namespace Ballerz.Football.Ballerz.Services
{
    public interface IPersonImage
    {
           IEnumerable<ClubPersonImages> GetAll(); 
        
         Task Create(ClubPersonImages personImage);
         Task Edit(int personImage);
         Task Delete(int personImage); 
    }
}