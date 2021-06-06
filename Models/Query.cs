﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EductionFinalProject.Models
{
    public class Query
    {
        public int id { get; set; }

        [Display(Name = "Name ")]
        public string Product { get; set; }

        [Display(Name = "Email  ")]
        public string Email { get; set; }

        [Display(Name = "Message ")]
        public string Message { get; set; }

    }
}
