using System;
using System.Reflection;
using System.Collections.Generic;


namespace Zeiss.ObjectValidatorLib {
    // Reflection can call object private data members. Violation of Abstraction.
    public class ObjectValidator {
        public static bool Validate(object obj, out List<string> errors) {
            errors = new List<string>();

            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties) {
                object[] validationAttributes =
                    property.GetCustomAttributes(typeof(ValidationAttribute), true);

                foreach (ValidationAttribute validationAttribute in validationAttributes) {
                    ValidationAttribute attribute = validationAttribute as ValidationAttribute;

                    object propertyValue = property.GetValue(obj);

                    if (!attribute.isValid(propertyValue)) {
                        string errorMessage = attribute.ErrorMessage;
                        errors.Add(errorMessage);
                    }
                }
            }

            return errors.Count == 0;
        }
    }
}