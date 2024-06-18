using System;
using System.Collections.Generic;
using System.Text;

namespace TadkarSample1.Core.ViewModels
{
   public class PersonnelViewModel
   {
      public int Id { get; set; }
      public string FName { get; set; }
      public string LName { get; set; }
      public int City_Id { get; set; }
      public int Province_Id { get; set; }
      public string Address { get; set; }
      public string City_Name { get; set; }
      public string Province_Name { get; set; }

   }
}
