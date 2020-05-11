using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolScoreMVC.Models.DegreeViewModels
{
    public class AllDegreesViewModel
    {
        public int DegreeId { get; set; }

        public string EducationName { get; set; }

        //public List<School> Schools { get; set; }


        public IEnumerable<SingleDegreeListViewModel> Degrees
        //public IEnumerable<SingleDegreeListViewModel> Degrees
        {
            get; set;
        }

    }
}