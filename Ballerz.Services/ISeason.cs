using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;

namespace Ballerz.Football.Ballerz.Services
{
    public interface ISeason
    {
           Task Create(Seasons seasons); 
        IEnumerable<Seasons> GetAll();
    }
}