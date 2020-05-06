using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace SchoolScoreMVC.Models
{
    public class MyCareerOption
    {

        [Required]
        public int Id { get; set; }

        public Boolean SearchSchool { get; set; }

        public Boolean ShortList { get; set; }

        //public int CustomerId { get; set; }

        [Required]
        public int DegreeSchoolId { get; set; }

        [Required]
        public DegreeSchool DegreeSchool { get; set; }
        

        [Required]
        public string ApplicationUserId { get; set; }

        [Required]
        public ApplicationUser ApplicationUser { get; set; }
        // one user can have many career options

       
        //public int LoanId { get; set; }



    }
}
