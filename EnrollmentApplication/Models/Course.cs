using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        [Display(Name ="Course ID")]
        public virtual int CourseId { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "Enter a course title less than 150 characters")]
        [Display(Name = "Course Title")]
        public virtual string Title { get; set; }
        
        [Display(Name = "Description")]
        public virtual string Description { get; set; }

        [Required]
        [Range(typeof(int),"1","4", ErrorMessage ="Enter a credit amount between 1 and 4")]
        [Display(Name = "Number of credits")]
        public virtual int Credits { get; set; }

    }
}