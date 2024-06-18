using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TadkarSample1.Core.ViewModels;
using TadkarSample1.DataAccessLayer.Entities;

namespace TadkarSample1.Core.Classes
{
   public class PersonnelProfile : Profile
   {
      public PersonnelProfile()
      {
         CreateMap<Personnel, PersonnelViewModel>();
      }
   }
}
