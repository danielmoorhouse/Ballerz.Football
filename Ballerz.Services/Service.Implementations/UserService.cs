using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Data;

namespace Ballerz.Football.Ballerz.Services.Service.Implementations
{
    public class UserService : IUser
    {
              private readonly ApplicationDbContext _db;

        public UserService(ApplicationDbContext db)
        {
            _db = db;
        }

    
        public ApplicationUser GetById(string id)
        {
            return _db.ApplicationUsers.Where(u => u.Id == id).FirstOrDefault();
        }

        // public async Task UpdateUserRating(string userId, Type type)
        // {
        //     var user = GetById(userId);
        //     user.Rating = CalculateUserRating(type, user.Rating);
        //     await _db.SaveChangesAsync();
        // }

        // private int CalculateUserRating(Type type, int userRating)
        // {
        //     var inc = 0;

        //     if (type == typeof(Post))
        //         inc = 1;

        //     if (type == typeof(PostReply))
        //         inc = 3;

        //     return userRating + inc;
        // }

    



        IEnumerable<ApplicationUser> IUser.GetAll()
        {
            return _db.ApplicationUsers.ToList();
        }

        //public async Task<ApplicationUser> GetByUsername(string userName)
       // {
            //return await _db.ApplicationUsers.FirstOrDefaultAsync(u => u.UserName == userName);
      //  }

       // public async Task<ApplicationUser> GetByUsernameOrId(string userName)
        //{
            //return await _db.ApplicationUsers.FirstOrDefaultAsync(u => u.UserName == userName || u.Id == userName);
     //   }
   


     
    }
}