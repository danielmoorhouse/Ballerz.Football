using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Data;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;

namespace Ballerz.Football.Ballerz.Services.Service.Implementations
{
    public class CountriesService : ICountries
    {
         private readonly ApplicationDbContext _db;
        public CountriesService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(Countries countries)
        {
            _db.Add(countries);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(int countriesId)
        {
            var countries = GetById(countriesId);
            _db.Remove(countries);
            await _db.SaveChangesAsync();
        }

        public Task Edit(int countriesId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Countries> GetAll()
        {
            return _db.Countries.ToList();
        }

        public Task<Countries> GetByCountryName(string countryName)
        {
            throw new NotImplementedException();
        }

        public Countries GetById(int id)
        {
            var countries = _db.Countries.Where(c => c.Id == id).FirstOrDefault();
            return countries;
        }

        public Countries GetCountryName(int id)
        {

throw new NotImplementedException();
        }



     
    }
}