namespace Ballerz.Football.Ballerz.Services
{
    public interface IApplicationUser
    {
        ApplicationUser GetById(string id);
        IEnumerable<ApplicationUser> GetAll();
        
        Task<ApplicationUser> GetByUsername(string userName);
        Task<ApplicationUser> GetByUsernameOrId(string userName);

        Task SetProfileImage(string id, Uri uri);
        Task UpdateUserRating(string id, Type type);
    }
}