using OS.WpfDevExpress.Domain.CsvRopository;
using System.Windows;

namespace OS.FunWith.WpfDevExpress
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string pathToFile = "..\\..\\..\\..\\data\\Employees.csv";

            CsvEmployeeRepository repository = new CsvEmployeeRepository();
            var result = repository.GetItems();


            // Test code

            //using (var reader = new StreamReader(pathToFile))
            //using (var csv = new CsvReader(reader))
            //{
            //    var records = csv.GetRecords<Employee>().ToList();
            //}
        }
    }
}
