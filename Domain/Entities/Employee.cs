using CsvHelper.Configuration.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OS.WpfDevExpressPlc.Domain.Entities
{
    public class Employee
    {
        [Name("FirstName")]
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Name("LastName")]
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }

        [Name("Position")]
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Position { get; set; }

        [Name("Office")]
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Office { get; set; }

        [Name("StartDate")]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public string StartDate { get; set; }

        [Name("Salary")]
        [Required]
        [Range(1, 100000000)]
        public string Salary { get; set; }

    }
}
