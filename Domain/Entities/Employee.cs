using CsvHelper.Configuration.Attributes;

namespace OS.WpfDevExpressPlc.Domain.Entities
{
    public class Employee
    {
        [Name("First name")]
        public string FirstName { get; set; }

        [Name("Last name")]
        public string LastName { get; set; }

        [Name("Position")]
        public string Position { get; set; }

        [Name("Office")]
        public string Office { get; set; }

        [Name("Start date")]
        public string StartDate { get; set; }

        [Name("Salary")]
        public string Salary { get; set; }

    }
}
