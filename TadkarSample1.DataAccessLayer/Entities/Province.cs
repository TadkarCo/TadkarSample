using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TadkarSample1.DataAccessLayer.Entities
{
   public class Province
   {
      [Key]
      public int Id { get; set; }
      public string name { get; set; }
      public virtual ICollection<City> Cities { get; set; }
   }
}
