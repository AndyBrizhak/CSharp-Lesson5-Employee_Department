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

namespace Employee_Department
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private Department _selectedDep;

        public MainWindow()
        {
            InitializeComponent();
            List<Department> dep_list = new List<Department>();
            dep_list.Add(new Department() { Name = "Laundry" });
            dep_list.Add(new Department() { Name = "Receiving room" });
            dep_list.Add(new Department() { Name = "Morgue" });
            //Department.ItemsSource = dep_list;
            DepComboBox.Items.Clear();
            foreach (var item in dep_list)
            {
                DepComboBox.Items.Add(item);
            }


            List<Employee> emp_list = new List<Employee>();
            emp_list.Add(new Employee("Lozhkin", dep_list[0]));
            emp_list.Add(new Employee("Pupkin", dep_list[1]));
            emp_list.Add(new Employee("Ivanov", dep_list[2]));
            //Employee.ItemsSource = emp_list;++
            EmpComboBox.Items.Clear();
            foreach (var item in emp_list)
            {
                EmpComboBox.Items.Add(item);
            }
        }

        //private void Department_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    //if (Department.SelectedItem == null) return;
        //    //var index = Department.SelectedIndex;
        //    //_selectedDep = Department.SelectedItem;
        //}
    }
}
