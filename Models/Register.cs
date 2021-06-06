using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EductionFinalProject.Models
{
    public class Register { 
     public int id { get; set; }

    [Display(Name = "User Name ")]
    public string userName { get; set; }

    [Display(Name = "Password  ")]
    public string Password { get; set; }

}
}
