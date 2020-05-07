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
    public class MatchingSchoolsViewModel
    {

        //public List<School> Schools { get; set; }


        public IEnumerable<SingleSchoolMatchViewModel> Schools { get; set; }
    }
}
