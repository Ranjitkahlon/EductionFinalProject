using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EductionFinalProject.Models
{
    public class CourseRecord
    {
        public int id { get; set; }

        [Display(Name = "Name ")]
        public string Product { get; set; }

        [Display(Name = "Duration ")]
        public string Duration { get; set; }

        [Display(Name = "Fee  ")]
        public int Fee { get; set; }


    }
}
