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
    public class SingleDegreeListViewModel
    {
        public int SchoolId { get; set; }

        public int DegreeId { get; set; }

        [Display(Name = "Degree / Program")]
        public string EducationName { get; set; }

        [Display(Name = "Average")]
        public string EarningAvg { get; set; }

        [Display(Name = "High")]
        public string EarningHigh { get; set; }

        [Display(Name = "Low")]
        public string EarningLow { get; set; }


        public IEnumerable<SingleDegreeListViewModel> Degrees { get; set; }
    }
}