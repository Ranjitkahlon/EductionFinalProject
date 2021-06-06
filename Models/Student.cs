using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EductionFinalProject.Models
{
    public class Student
    {
        public int id { get; set; }

        [Display(Name = "Name ")]
        public string Product { get; set; }

        [Display(Name = "Father Name  ")]
        public string FatherName { get; set; }

        [Display(Name = "Contact ")]
        public string Contact { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }


        [Display(Name = "Course")]
        public string Course { get; set; }
    }
}
