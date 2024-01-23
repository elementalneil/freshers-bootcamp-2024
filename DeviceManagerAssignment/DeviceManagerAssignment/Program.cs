using System;
using System.Collections.Generic;
using Zeiss.ObjectValidatorLib;


class Device {

    [Required(ErrorMessage = "ID Property Requires Value")]
    public string Id { get; set; }

    [Range(10, 100, "Code Value Must Be Within 10-100")]
    public int Code { get; set; }

    [MaxLength(100, "Max of 100 Charcters are allowed")]
    public string Description { get; set; }

    [PatternEvaluator("Barcode is Invalid")]
    public string BarCode { get; set; }
}


// Reflection is expensive when you use value-type
// This is because it causes boxing and unboxing
class Program {
    static void Main() {
        Device deviceObj = new Device();

        deviceObj.Code = 123;
        deviceObj.Description = "Hello WorldHello WorldHello WorldHello WorldHello WorldHello" +
            " WorldHello WorldHello WorldHello WorldHello WorldHello WorldHello World";
        deviceObj.BarCode = "zabc123456789012";
        
        bool isValid = ObjectValidator.Validate(deviceObj, out List<string> errors);
        if (!isValid) {
            foreach (string item in errors) {
                Console.WriteLine(item);
            }
        }
        else {
            Console.WriteLine("All Good");
        }

        Console.ReadLine();
    }
}