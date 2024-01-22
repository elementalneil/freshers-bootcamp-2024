using System.Collections.Generic;
using System;
using System.Reflection;

namespace DeviceNamespace { 
    [AttributeUsage(AttributeTargets.Property)]
    sealed class RequiredAttribute : Attribute {
        public string ErrorMessage { get; }

        public RequiredAttribute(string errorMessage) {
            ErrorMessage = errorMessage;
        }

        public bool IsValid(object value) {
            return value != null && !string.IsNullOrWhiteSpace(value.ToString());
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    sealed class RangeAttribute : Attribute {
        public int Min { get; }
        public int Max { get; }
        public string ErrorMessage { get; }

        public RangeAttribute(int min, int max, string errorMessage) {
            Min = min;
            Max = max;
            ErrorMessage = errorMessage;
        }

        public bool IsValid(object value) {
            if (value is int intValue) {
                return intValue >= Min && intValue <= Max;
            }
            return false;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    sealed class MaxLengthAttribute : Attribute {
        public int MaxLength { get; }
        public string ErrorMessage { get; }

        public MaxLengthAttribute(int maxLength, string errorMessage) {
            MaxLength = maxLength;
            ErrorMessage = errorMessage;
        }

        public bool IsValid(object value) {
            if (value is string strValue) {
                return strValue.Length <= MaxLength;
            }
            return false;
        }
    }


    class Device {

        [Required("ID Property Requires Value")]
        public string Id { get; set; }

        [Range(10, 100, "Code Value Must Be Within 10-100")]
        public int Code { get; set; }

        [MaxLength(100, "Max of 100 Charcters are allowed")]
        public string Description { get; set; }

    }


    public class ObjectValidator {
        public static bool Validate(object obj, out List<string> errors) {
            errors = new List<string>();

            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (PropertyInfo property in properties) {
                var attributes = property.GetCustomAttributes(true);

                foreach (var attribute in attributes) {
                    if (attribute is Attribute validationAttribute) {
                        object propertyValue = property.GetValue(obj);

                        if (!validationAttribute.IsValid(propertyValue)) {
                            string errorMessage = $"{property.Name}: {validationAttribute.ErrorMessage}";
                            errors.Add(errorMessage);
                        }
                    }
                }
            }

            // Return true if there are no validation errors
            return errors.Count == 0;
        }
    }


    class Program {
        static void Main() {
            Device deviceObj = new Device();
            List<string> errors;
            bool isValid = ObjectValidator.Validate(deviceObj, out List<string> errors);
            if (!isValid) {
                foreach (string item in errors) {
                    System.Console.WriteLine(item);

                }
            }
        }
    }
}