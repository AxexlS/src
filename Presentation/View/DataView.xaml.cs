using OS.FunWith.WpfDevExpress.ViewModel;
using OS.WpfDevExpressPlc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OS.FunWith.WpfDevExpress.View
{
    /// <summary>
    /// Interaction logic for DataView.xaml
    /// </summary>
    public partial class DataView : UserControl
    {
        public DataView()
        {
            InitializeComponent();
        }

        public IEnumerable<Employee> MyProperty { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var t = DataContext;
        }

        private void GridControl_SelectionChanged(object sender, DevExpress.Xpf.Grid.GridSelectionChangedEventArgs e)
        {

        }

        private void TableView_CellValueChanged(object sender, DevExpress.Xpf.Grid.CellValueChangedEventArgs e)
        {
            //((DataViewModel)DataContext).
        }
    }
}
