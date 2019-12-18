using DevExpress.Mvvm;
using OS.WpfDevExpress.Domain.CsvRopository;
using OS.WpfDevExpressPlc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.FunWith.WpfDevExpress.ViewModel
{
    public class DataViewModel : ViewModelBase
    {
        private CsvEmployeeRepository EmployeeRepository { get; set; }

        public DataViewModel()
        {
            EmployeeRepository = new CsvEmployeeRepository();
        }

        public IEnumerable<Employee> Employees
        {
            get
            {
                return EmployeeRepository.GetItems();
            }
            set
            {
                EmployeeRepository.Save();
                
            }
        }
    }
}
