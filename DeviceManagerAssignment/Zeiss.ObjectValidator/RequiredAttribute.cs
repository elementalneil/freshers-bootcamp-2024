using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeiss.ObjectValidatorLib {
    public class RequiredAttribute : ValidationAttribute {
        public override bool isValid(object obj) {
            return obj != null && !string.IsNullOrWhiteSpace(obj.ToString());
        }
    }
}