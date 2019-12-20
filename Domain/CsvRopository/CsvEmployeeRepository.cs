using OS.WpfDevExpress.Domain.CsvRopository.Data;
using OS.WpfDevExpress.Domain.Repository;
using OS.WpfDevExpressPlc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OS.WpfDevExpress.Domain.CsvRopository
{
    public class CsvEmployeeRepository : IRepository<Employee>
    {
        private EmployeeContext dataContext;

        public CsvEmployeeRepository()
        {
            // TODO : Inject path of file
            dataContext = new EmployeeContext("..\\..\\..\\..\\data\\Employees.csv");
        }

        public void Create(Employee item)
        {
            dataContext.Employees.Add(item);
        }

        public void Delete(Employee item)
        {
            if (item != null)
            {
                dataContext.Employees.Remove(FindEmployee(item));
            }
        }

        public Employee GetEmployee(Employee item)
        {
            return dataContext.Employees.FirstOrDefault(i => i.FirstName == item.FirstName &&
                                                      i.LastName == item.LastName &&
                                                      i.Office == item.Office &&
                                                      i.Position == item.Position);
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
            //var existingEmployee = dataContext.Employees.FirstOrDefault(i => i.FirstName == item.FirstName &&
            //                                          i.LastName == item.LastName &&
            //                                          i.Office == item.Office &&
            //                                          i.Position == item.Position);
            //dataContext.Employees.Remove(existingEmployee);
            //dataContext.Employees.Add(item);

            throw new NotImplementedException();
        }

        public void Dispose()
        {
            dataContext.Write();
            dataContext = null;
        }

        private Employee FindEmployee(Employee item)
        {
            return dataContext.Employees.FirstOrDefault(i => i.FirstName == item.FirstName &&
                                                      i.LastName == item.LastName &&
                                                      i.Office == item.Office &&
                                                      i.Position == item.Position);
        }
    }
}
