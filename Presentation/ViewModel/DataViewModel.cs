using DevExpress.Mvvm;
using OS.WpfDevExpress.Domain.CsvRopository;
using OS.WpfDevExpressPlc.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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

        public ICommand RemoveEmployee { get; }

        private CsvEmployeeRepository EmployeeRepository { get; set; }
        public Employee SelectedItem { get; set; }

        public DataViewModel()
        {
            EmployeeRepository = new CsvEmployeeRepository();

            SaveData = new DelegateCommand(() => EmployeeRepository.Save());
            AddEmployee = new DelegateCommand(AddNewEmployee);
            RemoveEmployee = new DelegateCommand(RemoveNewEmployee);
        }

        private void AddNewEmployee()
        {
            //Employees = Employees.ToList().Add(new Employee());
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


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

