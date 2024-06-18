using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TadkarSample1.DataAccessLayer.Entities
{
   public class Personnel
   {
      [Key]
      public int Id { get; set; }
      [StringLength(50)]
      public string FName { get; set; }
      [StringLength(50)]
      public string LName { get; set; }
      public int City_Id { get; set; }
      public int Province_Id { get; set; }
      public string Address { get; set; }
      [ForeignKey("City_Id")]
      public virtual City City { get; set; }
   }
}
