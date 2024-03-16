using hoteLL.OTELDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;
using hoteLL.OTELDataSetTableAdapters;

namespace hoteLL
{
    /// <summary>
    /// Логика взаимодействия для Sales.xaml
    /// </summary>
    public partial class Sales : Window
    {
        SalesDepartmentTableAdapter salesDepartment = new SalesDepartmentTableAdapter();
        public Sales()
        {
            InitializeComponent();
            SalesDepartmentDataGrid.ItemsSource = salesDepartment.GetData();
            SalesDepartmentComboBox.ItemsSource = salesDepartment.GetData();
            SalesDepartmentComboBox.DisplayMemberPath = "SaleAmount";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (SalesDepartmentComboBox.SelectedItem as DataRowView).Row[1];
            MessageBox.Show(cell.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }
    }
}
