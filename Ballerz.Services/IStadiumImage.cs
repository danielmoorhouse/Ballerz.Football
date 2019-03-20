using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;

namespace Ballerz.Football.Ballerz.Services
{
    public interface IStadiumImage
    {
             IEnumerable<StadiumImages> GetAll(); 
        
         Task Create(StadiumImages stadiumImage);
         Task Edit(int stadiumImage);
         Task Delete(int stadiumImage); 
    }
}