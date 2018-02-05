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
        internal static List<Department> dep_list { get; set; }

        //private Department _selectedDep;

        List<Employee> emp_list = new List<Employee>();
        private Employee _selectedEmp;


        public MainWindow()
        {
            InitializeComponent();
            CreateDepartmens();
            Update();

            //DepComboBox.Items.Clear();
            //foreach (var item in dep_list)
            //{
            //    DepComboBox.Items.Add(item);
            //}

            emp_list.Add(new Employee("Lozhkin", dep_list[0]));
            emp_list.Add(new Employee("Pupkin", dep_list[1]));
            emp_list.Add(new Employee("Ivanov", dep_list[2]));
            EmpComboBox.Items.Clear();
            foreach (var item in emp_list)
            {
                EmpComboBox.Items.Add(item);
            }
                       
        }

        public void CreateDepartmens()
        {
            dep_list = new List<Department>()/* { d1, d2, d3 }*/;
            dep_list.Add(new Department("Laundry"));
            dep_list.Add(new Department("Receiving room"));
            dep_list.Add(new Department("Morgue"));
            //Department d1 = new Department("Laundry");
            //Department d2 = new Department("Receiving room");
            //Department d3 = new Department("Morgue");


        }

        public void Update()
        {
            DepComboBox.Items.Clear();
            foreach (var ob in dep_list) DepComboBox.Items.Add(ob.Name);
        }

        private void DepComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DepComboBox.SelectedItem == null) return;
            var index = DepComboBox.SelectedIndex;
            //_selectedDep = dep_list[index];
            //EditDep _editDepWindow = new EditDep(_selectedDep);
            EditDep _editDepWindow = new EditDep();
            _editDepWindow.Owner = this;
            _editDepWindow.ShowDialog();
        }

        private void EmpComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmpComboBox.SelectedItem == null) return;
            var index = EmpComboBox.SelectedIndex;
            _selectedEmp = emp_list[index];
            EditEmp _editEmpWindow = new EditEmp(_selectedEmp);
            _editEmpWindow.Owner = this;
            _editEmpWindow.ShowDialog();
        }
    }
}
