using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DbContextdata:DbContext
    {
        public DbContextdata(DbContextOptions<DbContextdata> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    Country obj = new Country()
        //    {
        //        CountryId = Guid.NewGuid(),
        //        CountryName = "India"
        //    };

        //    modelBuilder.Entity<Country>().HasData(obj);

        //}
    }
}
