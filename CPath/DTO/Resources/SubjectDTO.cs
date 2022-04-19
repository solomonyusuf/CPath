

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace CPath.DTO.Resources
{
    public class SubjectDTO
    {  
        public Guid SubjectId { get; set; }
        public Guid StudentId { get; set; }

        public string Name { get; set; }
        public string FirstTest { get; set; }
        public string SecondTest { get; set; }
        public string Attendance { get; set; }
        public string ExamScore { get; set; }
        public string Total { get; set; }
        public string ClassHighest { get; set; }

        public string ClassLowest { get; set; }

        public string Percentage { get; set; }
        public string Position { get; set; }
        public string Grade { get; set; }


        public DateTime TimeStamp { get; set; }

        public SubjectDTO()
        {
          
            TimeStamp =  DateTime.Now;  
        }


    }
}
