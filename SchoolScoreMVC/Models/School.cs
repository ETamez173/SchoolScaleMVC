using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolScoreMVC.Models
{
    public class School
    {

        [Required]
        public int Id { get; set; }


        public string SchoolName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        // this is to use the join table called DegreeSchool
        public List<DegreeSchool> DegreeSchools { get; set; }


    }
}
