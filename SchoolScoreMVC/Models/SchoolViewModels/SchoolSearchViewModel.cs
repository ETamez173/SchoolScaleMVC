using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolScoreMVC.Models.SchoolViewModels
{
    public class SchoolSearchViewModel
    {

        public int DegreeId { get; set; }

        [Display(Name = "Degree/Program")]
        public string EducationName { get; set; }

        [Display(Name = "School")]
        public string SchoolName { get; set; }


        [Display(Name = "Annual Cost")]
        public double AnnualCost { get; set; }

        [Display(Name = "Total Cost")]
        public double TotalCost { get; set; }

        public List<School> Schools { get; set; }

        public List<Degree> Degrees { get; set; }

        public List<DegreeSchool> DegreeSchools { get; set; }
    }
}
