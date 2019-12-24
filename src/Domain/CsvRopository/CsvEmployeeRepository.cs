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
        #region Property

        private EmployeeContext dataContext;

        #endregion

        #region Ctor

        public CsvEmployeeRepository()
        {
            // TODO : Inject path of file
            dataContext = new EmployeeContext("..\\..\\..\\..\\data\\Employees.csv");
        }

        #endregion

        #region IRepository

        public ICollection<Employee> GetItems()
        {
            dataContext.Read();
            return dataContext.Employees;
        }

        public Employee GetItem(Employee item)
        {
            return FindEmployee(item);
        }

        public void Create(Employee item)
        {
            dataContext.Employees.Add(item);
        }

        public void Update(Employee item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Employee item)
        {
            if (item != null)
            {
                dataContext.Employees.Remove(FindEmployee(item));
            }
        }

        public void Save()
        {
            dataContext.Write();
        }

        #endregion

        #region dispose
        public void Dispose()
        {
            dataContext.Write();
            dataContext = null;
        }
        #endregion

        #region Private methods
        private Employee FindEmployee(Employee item)
        {
            return dataContext.Employees.FirstOrDefault(i => i.FirstName == item.FirstName &&
                                                      i.LastName == item.LastName &&
                                                      i.Office == item.Office &&
                                                      i.Position == item.Position);
        }
        #endregion
    }
}
