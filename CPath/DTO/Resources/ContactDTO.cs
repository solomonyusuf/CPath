using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CPath.DTO.Resources
{
    public class ContactDTO
    {
      
        public Guid id { get; set; }
       
        public string FullName { get; set; }
        
        public string Email { get; set; }
       
        public string PhoneNumber { get; set; }
        
        public string Message { get; set; }
    }
}
