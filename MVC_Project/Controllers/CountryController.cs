using Microsoft.AspNetCore.Mvc;
using ServiceContracts.DTO;
using ServiceContracts.Interface;

namespace MVC_Project.Controllers
{
    public class CountryController : Controller
    {
        private ICountrySC Country;
        public CountryController(ICountrySC country) 
        {
            this.Country = country;
        }

        [HttpGet]
        [Route("/")]
        public ViewResult ADD()
        {
            return View();
        }


        //[HttpPost]
        //public CountryResponse ADD(CountryAddRequest DataofCountry)
        //{
        //    CountryResponse DataOutput = Country.AddCountry(DataofCountry);
        //    return DataOutput;
        //}

        [HttpPost]
        public IActionResult ADD(CountryAddRequest dataofCountry)
        {
            CountryResponse response = Country.AddCountry(dataofCountry);
            return View("Result",response);
        }



    }
}
