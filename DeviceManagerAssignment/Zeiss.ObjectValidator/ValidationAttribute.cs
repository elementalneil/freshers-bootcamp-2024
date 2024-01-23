using System;

namespace Zeiss.ObjectValidatorLib {
    [AttributeUsage(AttributeTargets.Property)]
    abstract public class ValidationAttribute : Attribute {
        public string ErrorMessage { get; set; }

        public abstract bool isValid(object obj);
    }
}