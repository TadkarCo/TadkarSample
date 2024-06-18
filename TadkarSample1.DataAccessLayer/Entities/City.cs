using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TadkarSample1.DataAccessLayer.Entities
{
   public class City
   {
      [Key]
      public int Id { get; set; }
      public string name { get; set; }
      public int Province_Id { get; set; }
      [ForeignKey("Province_Id")]
      public virtual Province Province { get; set; }
      public virtual ICollection<Personnel> Personnels { get; set; }
   }
}
