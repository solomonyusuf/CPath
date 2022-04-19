using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CPath.DTO.Resources
{
    public class StudentDTO
    {
       
        public Guid StudentId { get; set; }
      
        public string ImgPath { get; set; }
       
        public string FirstName { get; set; }
     
        public string LastName { get; set; }
     
        public string MiddleName { get; set; }
       
        public string Class { get; set; }
      
        public string Sex { get; set; }
       
        public string DOB { get; set; }
      
        public string OriginState { get; set; }
        public ParentInfoDTO ParentInfo { get; }
        public ICollection<ResultDTO> Results { get; }
        public int TotalResult { get; }
        public DateTime TimeStamp { get; set; }

       
        public StudentDTO()
        {
            Results= new Collection<ResultDTO>();
            TotalResult = Results.Count;
            TimeStamp = DateTime.Now;
        }
    }
}
