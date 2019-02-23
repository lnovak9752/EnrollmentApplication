using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Student
    {
        [Display(Name ="Student ID")]
        public virtual int StudentId { get; set; }

        [Required]
        [StringLength(50,ErrorMessage = "Enter a last name less than 50 letters")]
        [Display(Name ="Last Name")]
        public virtual string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Enter a first name less than 50 letters")]
        [Display(Name ="First Name")]
        public virtual string FirstName { get; set; }

    }
}