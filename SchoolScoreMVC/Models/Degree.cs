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

        [Display(Name = "Degree/Program")]
        public string EducationName { get; set; }

        [Display(Name = "Yearly Earnings Average")]
        public double EarningAvg { get; set; }

        [Display(Name = "Yearly Earnings High")]
        public double EarningHigh { get; set; }

        [Display(Name = "Yearly Earnings Low")]
        public double EarningLow { get; set; }

        public List<DegreeSchool> DegreeSchools { get; set; }

    }
}
