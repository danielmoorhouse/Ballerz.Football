using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Data;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;
using Ballerz.Football.Ballerz.Services;
using Ballerz.Football.Ballerz.Web.Models.Countries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ballerz.Football.Ballerz.Web.Controllers
{
    public class CountriesController : Controller
    {
        private readonly ICountries _countriesService;
        private readonly ApplicationDbContext _db;
     


        public CountriesController(ICountries countriesService, ApplicationDbContext db)
        {
            _countriesService = countriesService;
            _db = db;
       
        }
        public IActionResult Index()
        {
           
            var countries = _countriesService.GetAll()
             .OrderBy(country => country.CountryName)
             .Select(c => new CountryListingModel
             {
                Id= c.Id,
                Name = c.CountryName,
                FlagUrl = c.FlagUrl,
                ContinentId = c.ContinentId, 
                ContinentName = _db.Continents.Where(e => e.Id == c.ContinentId).FirstOrDefault().ContinentName
             });
            // ViewBag.ContinentName = _db.Continents.Where(d => d.Id == ContinentId).FirstOrDefault();
            var model = new CountryIndexModel
            {
                CountriesList = countries,
                
            };
            
            return View(model);

        }

        public IActionResult Create()
        {
        var continents = _db.Continents.OrderBy(c => c.ContinentName)
                                        .Select(x => new {Id= x.Id, Value = x.ContinentName});
        var model = new AddCountryModel();
        model.ContinentList = new SelectList(continents, "Id", "Value");
        return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddCountry(AddCountryModel model, IFormCollection UploadFlag)
        {
          
            string storePath = "/images/flags/";
            var path = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "flags",
                     UploadFlag.Files[0].FileName);
            using (var stream = new FileStream(path, FileMode.Create))
           {
               await UploadFlag.Files[0].CopyToAsync(stream); 
            }

      
         
       
            var countries = new Countries
            {
                CountryName = model.Name,
                FlagUrl = storePath + model.UploadFlag.FileName,
                ContinentId = model.ContinentId
            };
            await _countriesService.Create(countries);
            return RedirectToAction("Index", "Countries");

        }

      
    }    
   }