using OS.WpfDevExpress.Domain.CsvRopository.Data;
using OS.WpfDevExpress.Domain.Repository;
using OS.WpfDevExpressPlc.Domain.Entities;
using System;
using System.Collections.Generic;

namespace OS.WpfDevExpress.Domain.CsvRopository
{
    public class CsvEmployeeRepository : IRepository<Employee>
    {
        EmployeeContext dataContext;

        public CsvEmployeeRepository()
        {
            dataContext = new EmployeeContext("..\\..\\..\\..\\data\\Employees.csv");
        }

        public void Create(Employee item)
        {
            throw new NotImplementedException();
            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ICollection<Employee> GetItems()
        {
            dataContext.Read();
            return dataContext.Employees;
        }

        public void Save()
        {
            dataContext.Write();
        }

        public void Update(Employee item)
        {
            throw new NotImplementedException();
        }

        Employee IRepository<Employee>.GetEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
