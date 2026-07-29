
using ServiceContracts.Interface;

using ServiceContracts.DTO;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CountryService : ICountrySC
    {
        private List<Country> _countries;

        private readonly DbContextdata _db;

        public CountryService(DbContextdata db)
        {
            _db = db;
        }

        public CountryResponse AddCountry(CountryAddRequest countryAddRequest) 
        {
         Country countryobj = new Country();

         countryobj.CountryName = countryAddRequest.CountryName;

            // countryobj.CountryId = Guid.Parse("2712D163-E2AA-4307-8A63-406A3853F2CB");
            countryobj.CountryId = Guid.NewGuid();
            //_countries = new List<Country>();
            //_countries.Add(countryobj);


            try
            {
                _db.Countries.Add(countryobj);
                int rows = _db.SaveChanges();
                Console.WriteLine(rows);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }

            CountryResponse countryresp = new CountryResponse();
            countryresp.CountryId = countryobj.CountryId;
            countryresp.CountryName = countryobj.CountryName;
            return countryresp;

        }






    }
}
