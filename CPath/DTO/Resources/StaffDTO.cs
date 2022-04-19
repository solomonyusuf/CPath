using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CPath.DTO.Resources
{
    public class StaffDTO
    {
        
        public Guid StaffId { get; set; }

        public string ImgPath { get; set; }
       
        public string FirstName { get; set; }
     
        public string LastName { get; set; }
      
        public string MiddleName { get; set; }
       
        public string Email { get; set; }
        
        public string Address { get; set; }
       
        public string School { get; set; }
      
        public string Subject { get; set; }
     
        public string PhoneNumber { get; set; }
     
        public string Position { get; set; }
       
        public string DOB { get; set; }
        
        public string OriginState { get; set; }

        public DateTime TimeStamp { get; set; }

        public StaffDTO()
        {

            TimeStamp = DateTime.Now;
        }

    }
}
