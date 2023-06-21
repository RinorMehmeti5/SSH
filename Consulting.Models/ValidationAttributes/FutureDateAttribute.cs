using System;
using System.ComponentModel.DataAnnotations;
using Consult.Models;
namespace Consulting.ValidationAttributes
{
    public class FutureDateAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is DateTime dateTime)
            {
                if (dateTime > DateTime.Now)
                {
                    return true;
                }
            }

            return false;
        }

        public override string FormatErrorMessage(string name)
        {
            return "Date and time must be in the future.";
        }
    }
}
