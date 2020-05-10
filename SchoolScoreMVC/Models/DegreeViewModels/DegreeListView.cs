using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolScoreMVC.Models.DegreeViewModels
{
    public class DegreeListView
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Degree/Program")]
        public string EducationName { get; set; }

        [Display(Name = "Average")]
        public string EarningAvg { get; set; }

        [Display(Name = "High")]
        public string EarningHigh { get; set; }

        [Display(Name = "Low")]
        public string EarningLow { get; set; }

        // this is to use the join table called DegreeSchool
        public List<DegreeSchool> DegreeSchools
        {
            get; set;
        }
    }
}