using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Whose_Turn_Now.Models
{
    public class JobModel
    {
        [Required]
        [Display(Name = "Shared Task Name")]
        public string TaskName { get; set; }

        [Display(Name = "Describe what your helpers will do")]
        public string Description { get; set; }

        [Display(Name = "Add Helpers")]
        public string AddHelper { get; set; }
        
        public int ID { get; set; }
    }
}