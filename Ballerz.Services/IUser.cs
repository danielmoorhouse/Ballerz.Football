using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Data;

namespace Ballerz.Football.Ballerz.Services
{
    public interface IUser
    {
        ApplicationUser GetById(string id);
        IEnumerable<ApplicationUser> GetAll();
        
      //  Task<ApplicationUser> GetByUsername(string userName);
       // Task<ApplicationUser> GetByUsernameOrId(string userName);
    }
}