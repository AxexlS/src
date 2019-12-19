using CsvHelper;
using OS.WpfDevExpressPlc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OS.WpfDevExpress.Domain.CsvRopository.Data
{
    public class EmployeeContext
    {
        public string PathToFile { get; private set; }
        public string Delimiter { get; private set; }

        public ICollection<Employee> Employees { get; set; }

        public EmployeeContext(string pathToFile, string delimiter = ",")
        {
            Delimiter = delimiter;

            try
            {
                PathToFile = Path.GetFullPath(pathToFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        public void Read()
        {
            using (StreamReader streamReader = new StreamReader(PathToFile))
            {
                using (CsvReader csvReader = new CsvReader(streamReader))
                {
                    csvReader.Configuration.Delimiter = Delimiter;
                    Employees = csvReader.GetRecords<Employee>().ToList();
                }
            }
        }

        public void Write()
        {
            try
            {
                using (var streamWriter = new StreamWriter(PathToFile))
                using (var csv = new CsvWriter(streamWriter))
                {
                    csv.WriteRecords(Employees);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }          
        }
    }
}
