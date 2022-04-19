using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CPath.Models.Subjects
{
    public class BookKeeping
    {
        [Key]
        [Required]
        public Guid id { get; set; }
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

    }
}
