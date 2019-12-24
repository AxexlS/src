using DevExpress.Mvvm;
using OS.WpfDevExpress.Domain.CsvRopository;
using OS.WpfDevExpressPlc.Domain.Entities;
using System.Collections.Generic;
using System.Windows.Input;

namespace OS.FunWith.WpfDevExpress.ViewModel
{
    public class DataViewModel : BaseViewModel
    {
        #region Property

        public ICollection<Employee> Employees
        {
            get
            {
                return EmployeeRepository.GetItems();
            }
        }

        public Employee SelectedItem { get; set; }

        private CsvEmployeeRepository EmployeeRepository { get; set; }
        #endregion

        #region Command

        public ICommand SaveData { get; }

        public ICommand AddEmployee { get; }

        public ICommand RemoveEmployee { get; }

        #endregion

        #region Ctor
        public DataViewModel()
        {
            EmployeeRepository = new CsvEmployeeRepository();

            SaveData = new DelegateCommand(() => EmployeeRepository.Save());
            AddEmployee = new DelegateCommand(AddNewEmployee);
            RemoveEmployee = new DelegateCommand(RemoveNewEmployee);
        }

        #endregion

        #region Private methods
        private void AddNewEmployee()
        {
            Employees.Add(new Employee());
            EmployeeRepository.Save();

            OnPropertyChanged(nameof(Employees));
        }

        private void RemoveNewEmployee()
        {
            EmployeeRepository.Delete(SelectedItem);
            EmployeeRepository.Save();

            OnPropertyChanged(nameof(Employees));
        }
        #endregion
    }
}

