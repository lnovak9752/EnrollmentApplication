using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        
        public virtual int EnrollmentId { get; set; }

        public virtual int StudentId { get; set; }

        public virtual int CourseId { get; set; }

        [Required]
        [RegularExpression("[A-Fa-f]",ErrorMessage ="Only use letters A-F")]
        public virtual string Grade { get; set; }

        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }

        public virtual bool isActive { get; set; }

        [Required]
        [Display(Name ="Assigned Campus")]
        public virtual string AssignedCampus { get; set; }

        [Required]
        [Display(Name = "Enrolled in Semester")]
        public virtual string EnrollmentSemester { get; set; }

        [Required]
        [Display(Name = "Enrollment Year")]
        [Range(typeof(int),"2018","2019",ErrorMessage ="Cannot be before 2018 or after 2019")]
        public virtual int EnrollmentYear { get; set; }
    }
}