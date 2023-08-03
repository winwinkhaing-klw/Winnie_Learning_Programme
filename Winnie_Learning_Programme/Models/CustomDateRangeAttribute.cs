using System;
using System.ComponentModel.DataAnnotations;

namespace Winnie_Learning_Programme.Models
{
    public class CustomDateRangeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime date)
            {
                // Check if the date is not in the future
                if (date > DateTime.Today)
                {
                    return new ValidationResult("The date must be in the past.");
                }
            }

            return ValidationResult.Success;
        }
    }
}