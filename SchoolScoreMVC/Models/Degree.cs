using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolScoreMVC.Models
{
    public class Degree
    {

        [Required]
        public int Id { get; set; }
        public string EducationName { get; set; }

        public double EarningAvg { get; set; }

        public double EarningHigh { get; set; }

        public double EarningLow { get; set; }
    }
}
