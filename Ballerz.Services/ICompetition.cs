using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;

namespace Ballerz.Football.Ballerz.Services
{
    public interface ICompetition
    {
        Competitions GetById(int id);
         IEnumerable<Competitions> GetAll(); 

           Task Create(Competitions competitions);
         Task Edit(int competitionsId);
         Task Delete(int competitionsId); 
    }
}