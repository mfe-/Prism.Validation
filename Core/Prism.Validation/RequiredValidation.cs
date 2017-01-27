using System;
using System.ComponentModel.DataAnnotations;

namespace Prism.Validation
{
    public class RequiredValidation : RequiredAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ValidationResult ValidationResult = new ValidationResult(String.Format("Value {0} required", validationContext.MemberName));

            if (validationContext == null && value == null) return ValidationResult;
            if (value == null) return ValidationResult;

            return ValidationResult.Success;
        }
    }
}
