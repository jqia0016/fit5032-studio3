using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FIT5032_week6.Models
{
    public class SampleView
    {
        [Required]
        [StringLength(20, ErrorMessage = "please enter between 5 to 20", MinimumLength =5)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "please enter between 2 to 20", MinimumLength = 2)]
        public string LastName { get; set; }
    }


}