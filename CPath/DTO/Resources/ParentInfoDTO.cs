using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CPath.DTO.Resources
{
     public class ParentInfoDTO
    {   
        public Guid ParentId { get; set; }
        
        public Guid StudentId { get; set; }

        public string ParentName { get; set; }
        
        public string Email { get; set; }
      
        public string Occupation { get; set; }
      
        public string City { get; set; }
      
        public string PhoneNumber_1 { get; set; }
        
        public string PhoneNumber_2 { get; set; }      
       
        public string Address_1 { get; set; }
       
        public string Address_2 { get; set; }
       
      

    }
}
