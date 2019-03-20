using System.Collections.Generic;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;

namespace Ballerz.Football.Ballerz.Services
{
    public interface IContinent
    {
         IEnumerable<Continents> GetAll(); 
    }
}