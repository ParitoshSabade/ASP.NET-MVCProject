using System;
using System.ComponentModel.DataAnnotations;

namespace MVCProject.CustomValidators
{
	public class DOBValidator : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value != null)
            {
                DateTime dateOfBirth = (DateTime)value;
                DateTime minDate = new DateTime(1990, 1, 1);

                if (dateOfBirth > minDate)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Date of birth should be after Jan 1, 1990.");
                }
            }
            return null;
            
        }
    }
}

