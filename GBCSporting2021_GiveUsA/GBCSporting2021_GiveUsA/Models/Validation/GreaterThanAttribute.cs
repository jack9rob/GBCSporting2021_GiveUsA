﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Models.Validation
{
    public class GreaterThanAttribute : ValidationAttribute
    {
        private object compareValue;

        public GreaterThanAttribute(object val)
        {
            compareValue = val;
        }

        protected override ValidationResult IsValid(object value, ValidationContext ctx)
        {
            if (value is int)
            {
                int intToCheck = (int)value;
                int intToCompare = (int)compareValue;
                if (intToCheck > intToCompare)
                {
                    return ValidationResult.Success;
                }

            }
            else if (value is double)
            {
                double doubleToCheck = (double)value;
                double doubleToCompare = (double)compareValue;
                if (doubleToCheck > doubleToCompare)
                {
                    return ValidationResult.Success;
                }
            }
            else if (value is DateTime)
            {
                DateTime dateToCheck = (DateTime)value;
                DateTime dateToCompare = new DateTime();
                DateTime.TryParse(compareValue.ToString(), out dateToCompare);


                if (dateToCheck > dateToCompare)
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return ValidationResult.Success;
            }
            

            string msg = base.ErrorMessage ?? $"{ctx.DisplayName} must be greater than {compareValue.ToString()}.";
            return new ValidationResult(msg);
        }
    }
}