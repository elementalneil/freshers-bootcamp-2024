using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeiss.ObjectValidatorLib {
    public class RangeAttribute : ValidationAttribute {
        public int Min { get; set; }
        public int Max { get; set; }

        public RangeAttribute(int min, int max, string errorMessage) {
            Min = min;
            Max = max;
            ErrorMessage = errorMessage;
        }

        public override bool isValid(object obj) {
            if (obj is int intValue) {
                return intValue >= Min && intValue <= Max;
            }
            return false;
        }
    }
}
