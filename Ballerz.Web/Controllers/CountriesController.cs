using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;
using Ballerz.Football.Ballerz.Services;
using Ballerz.Football.Ballerz.Web.Models.Countries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ballerz.Football.Ballerz.Web.Controllers
{
    public class CountriesController : Controller
    {
 private readonly ICountries _countriesService;
     


        public CountriesController(ICountries countriesService)
        {
            _countriesService = countriesService;
       
        }
        public IActionResult Index()
        {
           
            var countries = _countriesService.GetAll()
             .OrderBy(country => country.CountryName)
             .Select(c => new CountryListingModel
             {
                Id= c.Id,
                Name = c.CountryName,
                FlagUrl = c.FlagUrl
             });
            var model = new CountryIndexModel
            {
                CountriesList = countries
            };
            return View(model);

        }
        public IActionResult Create()
        {
        var model = new AddCountryModel();
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
                FlagUrl = storePath + model.UploadFlag.FileName
            };
            await _countriesService.Create(countries);
            return RedirectToAction("Index", "Countries");

        }

      
    }    
   }