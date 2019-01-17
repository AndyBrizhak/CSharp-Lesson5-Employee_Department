using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Configuration;


namespace Employee_Department
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //internal static List<Department> dep_list { get; set; }
        internal static ObservableCollection<Department> dep_list { get; set; }   //add new
        //internal static List<Employee> emp_list { get; set; }
        internal static ObservableCollection<Employee> emp_list { get; set; }        //add new
        //private string _departments = 3;

        public MainWindow()
        {
            InitializeComponent();
            
            //var connectionString = new SqlConnectionStringBuilder
            //{
            //    DataSource = @"(LocalDb)\MSSQLLocalDB",
            //    InitialCatalog = "Employee"
            //}.ConnectionString;

            Department dep1 = new Department
            {
                Name = "Laundry"
            };
            Department dep2 = new Department
            {
                Name = "Receiving room"
            };

            Department dep3 = new Department
            {
                Name = "Morgue"
            };

            //var sqlExp1 = $@"INSERT INTO Dep(Name) VALUES ('{dep1.Name}')";//добавляем строки и наименования
            //var sqlExp2 = $@"INSERT INTO Dep(Name) VALUES ('{dep2.Name}')";
            //var sqlExp3 = $@"INSERT INTO Dep(Name) VALUES ('{dep3.Name}')";
            //var sqlExpDel = $@"DELETE FROM Dep WHERE Name = 'Laundry'";    //удаляем строки
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    SqlCommand command1 = new SqlCommand(sqlExp1, connection);
            //    var number1 = command1.ExecuteNonQuery();
            //    SqlCommand command2 = new SqlCommand(sqlExp2, connection);
            //    var number2 = command2.ExecuteNonQuery();
            //    SqlCommand command3 = new SqlCommand(sqlExp3, connection);
            //    var number3 = command3.ExecuteNonQuery();
            //    SqlCommand commandDel = new SqlCommand(sqlExpDel, connection);
            //    var number4 = commandDel.ExecuteNonQuery();
            //    Console.WriteLine(connection.State);
            //}


            CreateDepartmens();
            CreateEmployees();
            Update();
                            
        }

        public void CreateEmployees()
        {
            //emp_list = new List<Employee>();
            emp_list = new ObservableCollection<Employee>();              //add new
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
            dep_list = new ObservableCollection<Department>();
            dep_list.Add(new Department("Laundry"));
            dep_list.Add(new Department("Receiving room"));//
            dep_list.Add(new Department("Morgue"));
            DepComboBox.Items.Clear();
            foreach (var ob in dep_list) DepComboBox.Items.Add(ob.Name);
        }

        public void Update()   //+++
        {
            DepComboBox.Items.Clear();
            foreach (var ob in dep_list) DepComboBox.Items.Add(ob.Name);
            EmpComboBox.Items.Clear();
            foreach (var ob in emp_list) EmpComboBox.Items.Add(ob.Name);
        }

        private void DepComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DepComboBox.SelectedItem == null) return;
            EditDep _editDepWindow = new EditDep();
            _editDepWindow.Owner = this;
            _editDepWindow.ShowDialog();
        }

        private void EmpComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmpComboBox.SelectedItem == null) return;
            EditEmp editEmp = new EditEmp();
            editEmp.Owner = this;
            editEmp.ShowDialog();
        }
    }
}
