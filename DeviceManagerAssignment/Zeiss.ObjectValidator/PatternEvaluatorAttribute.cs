using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Zeiss.ObjectValidatorLib {
    public class PatternEvaluatorAttribute : ValidationAttribute {
        public PatternEvaluatorAttribute(string errorMessage) {
            ErrorMessage = errorMessage;
        }
        public override bool isValid(object obj) {
            string barCode = obj as string;

            if (barCode != null) {
                string pattern = @"^[Zz][A-Za-z]{3}\d{12}$";
                Regex regex = new Regex(pattern);

                return regex.IsMatch(barCode);
            }

            return false;
        }
    }
}
