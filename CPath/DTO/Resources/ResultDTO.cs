

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace CPath.DTO.Resources
{
    public class ResultDTO
    {  
        public Guid ResultId { get; set; }

        public Guid StudentId { get; set; }

        public string Class { get; set; }
      
        public string ClassHighest { get; set; }
       
        public string ClassLowest { get; set; }
       
        public string Percentage { get; set; }
      
        public string Position { get; set; }
       
        public string Term { get; set; }
      
        public string Session { get; set; }
        
        public ICollection<SubjectDTO> Subjects { get; set; }

        public DateTime TimeStamp { get; set; }

        public ResultDTO()
        {
          
            TimeStamp =  DateTime.Now;  
        }


    }
}
