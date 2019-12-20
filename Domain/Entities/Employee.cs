using CsvHelper.Configuration.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OS.WpfDevExpressPlc.Domain.Entities
{
    public class Employee
    {
        [Name("FirstName")]
        [ReadOnly(true)]
        [StringLengthAttribute(50, ErrorMessage = "Please input name")]
        //[RequiredAttribute(false, ErrorMessage = "Please input name")]
        public string FirstName { get; set; }

        [Name("LastName")]
        public string LastName { get; set; }

        [Name("Position")]
        public string Position { get; set; }

        [Name("Office")]
        public string Office { get; set; }

        [Name("StartDate")]

        public string StartDate { get; set; }

        [Name("Salary")]
        public string Salary { get; set; }

    }
}
