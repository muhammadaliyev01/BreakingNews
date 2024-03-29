﻿using BreakingNews.Service.Common.Validations;
using System.ComponentModel.DataAnnotations;
namespace BreakingNews.Service.Common.Attributes;
public class StrongPasswordAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is null) return new ValidationResult("Parol majburiy!");
        else
        {
            string password = value.ToString()!;
            if (password.Length < 8)
                return new ValidationResult("Parol eng kamida 8 ta belgidan iborat bo'lishi kerak!");
            else if (password.Length > 50)
                return new ValidationResult("Parol 50 ta belgidan kam bo'lishi kerak!");
            var result =PasswordValidator.IsStrong(password);

            if (result.IsValid is false) return new ValidationResult(result.Message);
            return ValidationResult.Success;
        }
    }
}
