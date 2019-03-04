using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class InvalidCharsAttribute : ValidationAttribute
    {
        readonly string chars;

        public InvalidCharsAttribute(string chars) : base("{0} contains unacceptable characters!")
        {
            this.chars = chars;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                var valueAsAString = value.ToString();
                if (valueAsAString.Contains(chars))
                {
                    var errormessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errormessage);
                }
            }

            return ValidationResult.Success;
            //return base.IsValid(value, validationContext);
        }
    }
}