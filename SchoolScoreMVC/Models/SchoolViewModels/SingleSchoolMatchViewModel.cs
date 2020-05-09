using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolScoreMVC.Models.SchoolViewModels
{
    public class SingleSchoolMatchViewModel
    {

        public int SchoolId { get; set; }

        [Display(Name = "Degree / Program")]
        public string EducationName { get; set; }

        [Display(Name = "School")]
        public string SchoolName { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Yearly Cost")]
        public string AnnualCost { get; set; }

        [Display(Name = "Total Cost")]
        public string TotalCost { get; set; }

       

   

    }
}
