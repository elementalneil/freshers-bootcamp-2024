using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zeiss.ObjectValidatorLib {
    public class MaxLengthAttribute : ValidationAttribute {
        public int MaxLength { get; set; }

        public MaxLengthAttribute(int maxLength, string errorMessage) {
            MaxLength = maxLength;
            ErrorMessage = errorMessage;
        }

        public override bool isValid(object obj) {
            if (obj is string strValue) {
                return strValue.Length <= MaxLength;
            }
            return false;
        }
    }
}