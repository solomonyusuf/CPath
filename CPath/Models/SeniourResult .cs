
using CPath.Models.Subjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace CPath.Models
{
    public class SeniourResult
    {   [Key]
        [Required]
        public Guid id { get; set; }
        [StringLength(10)]
        public string ResultId { get; set; }
        [StringLength(10)]
        public string Class { get; set; }
        [StringLength(10)]
        public string ClassHighest { get; set; }
        [StringLength(10)]
        public string ClassLowest { get; set; }
        [StringLength(10)]
        public string Percentage { get; set; }
        [StringLength(10)]
        public string Position { get; set; }
        [StringLength(10)]
        public string Session { get; set; }

        [StringLength(10)]
        public string Term { get; set; }
        public ICollection<English> English { get; }
        public ICollection<Maths> Maths { get; }
        public ICollection<French> French { get; }
        public ICollection<Yoruba> Yoruba { get; }
        public ICollection<SocicalStudies> SocicalStudies { get; }
        public ICollection<Music> Music { get; }
        public ICollection<Civic> Civic { get; }
        public ICollection<Computer> Computer { get; }
        public ICollection<Igbo> Igbo { get; }
        public ICollection<CreativeArts> CreativeArts { get; }
        public ICollection<Science> Science { get; }
        public ICollection<Literature> Literature { get; }
        public ICollection<Physics> Physics { get; }
        public ICollection<Chemistry> Chemistry { get; }
        public ICollection<Biology> Biology { get; }
        public ICollection<DataProcessing> DataProcessing { get; }
        public ICollection<Economics> Economics { get; }
        public ICollection<Government> Government { get; }
        public ICollection<FutherMaths> FutherMaths { get; }
        public ICollection<Commerce> Commerce { get; }
        public ICollection<BookKeeping> BookKeeping { get; }
        public ICollection<Catering> Catering { get; }
        public ICollection<TechnicalDrawing> TechnicalDrawing { get; }






        [StringLength(50)]
        [DataType(DataType.DateTime)]
        public DateTime TimeStamp { get; set; }

        public SeniourResult()
        {
            English = new Collection<English>();
            Maths = new Collection<Maths>();
            Civic = new Collection<Civic>();
            French = new Collection<French>();
            Yoruba = new Collection<Yoruba>();
            SocicalStudies = new Collection<SocicalStudies>();
            Music = new Collection<Music>();
            Computer = new Collection<Computer>();
            Igbo = new Collection<Igbo>();
            CreativeArts = new Collection<CreativeArts>();
            Science = new Collection<Science>();
            DataProcessing = new Collection<DataProcessing>();
            Chemistry = new Collection<Chemistry>();    
            Physics = new Collection<Physics>();    
            Commerce = new Collection<Commerce>();
            BookKeeping = new Collection<BookKeeping>();
            Catering = new Collection<Catering>();
            Economics = new Collection<Economics>();
            TechnicalDrawing = new Collection<TechnicalDrawing>();
            Literature = new Collection<Literature>();
            Biology = new Collection<Biology>();
            Government = new Collection<Government>();
            FutherMaths = new Collection<FutherMaths>();
            TimeStamp = DateTime.Now;


        }



    }
}
