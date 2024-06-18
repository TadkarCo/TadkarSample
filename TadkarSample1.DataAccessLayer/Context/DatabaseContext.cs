using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TadkarSample1.DataAccessLayer.Entities;

namespace TadkarSample1.DataAccessLayer.Context
{
   public class DatabaseContext : DbContext
   {
      public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
      {

      }

       public DbSet<Personnel> Personnel { get; set; }
       public DbSet<City> City { get; set; }
       public DbSet<Province> Province { get; set; }

   }
}
