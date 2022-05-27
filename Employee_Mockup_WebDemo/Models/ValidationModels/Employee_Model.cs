using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employee_Mockup_WebDemo.Models.ValidationModels
{
    public class Employee_Model
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Use letters only please")]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Employee´s name must be insert")]
        public string FirstName { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Use letters only please")]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Employee´s lastname must be insert")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [Required, EmailAddress]
        public string Email { get; set; }
    }
}