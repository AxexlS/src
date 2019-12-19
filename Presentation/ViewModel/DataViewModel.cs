using DevExpress.Mvvm;
using OS.WpfDevExpress.Domain.CsvRopository;
using OS.WpfDevExpressPlc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OS.FunWith.WpfDevExpress.ViewModel
{
    public class DataViewModel : INotifyPropertyChanged
    {
        public ICollection<Employee> Employees
        {
            get
            {
                return EmployeeRepository.GetItems();
            }
        }

        public ICommand SaveData { get; }

        public ICommand AddEmployee { get; }

        private CsvEmployeeRepository EmployeeRepository { get; set; }

        public DataViewModel()
        {
            EmployeeRepository = new CsvEmployeeRepository();

            SaveData = new DelegateCommand(() => EmployeeRepository.Save());
            AddEmployee = new DelegateCommand(AddNewEmployee);
        }

        private void AddNewEmployee()
        {
            //Employees = Employees.ToList().Add(new Employee());
            Employees.Add(new Employee());
            EmployeeRepository.Save();

            OnPropertyChanged(nameof(Employees));
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

