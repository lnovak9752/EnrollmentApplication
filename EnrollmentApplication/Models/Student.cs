using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Student : IValidatableObject
    {
        [Display(Name ="Student ID")]
        public virtual int StudentId { get; set; }

        [Required]
        [StringLength(50,ErrorMessage = "Enter a last name less than 50 letters")]
        [Display(Name ="Last Name")]
        [InvalidChars("*", ErrorMessage ="Last name cannot have invalid characters")]
        public virtual string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Enter a first name less than 50 letters")]
        [Display(Name ="First Name")]
        [InvalidChars("*")]
        public virtual string FirstName { get; set; }

        [MinimumAge(20)]
        public virtual int Age { get; set; }

        public virtual string Address1 { get; set; }
        public virtual string Address2 { get; set; }
        public virtual string City { get; set; }
        public virtual string Zipcode { get; set; }
        public virtual string State { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //Validation 1: Address 1 != Address2
            if(Address2 != null)
            {
                if (Address2.Equals(Address1))
                {
                    yield return (new ValidationResult("Address2 cannot be the same as Address1"));
                }
            }
            

            //Validation 2: State must be 2 digits long
            if (State.Length != 2)
            {
                yield return (new ValidationResult("Enter a 2 digit State code"));
            }

            //Validation 3: Zipcode must be 5 digits long
            if (Zipcode.Length != 5)
            {
                yield return (new ValidationResult("Enter a 5 digit Zipcode"));
            }

            throw new NotImplementedException();
        }
    }
}