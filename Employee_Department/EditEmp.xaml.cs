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
using System.Windows.Shapes;

namespace Employee_Department
{
    /// <summary>
    /// Логика взаимодействия для EditEmp.xaml
    /// </summary>
    public partial class EditEmp : Window
    {
        public EditEmp()
        {
            InitializeComponent();
            //Update();
            
        }

        //public void Update()
        //{
        //    //NamecomboBox.Items.Clear();
        //    //foreach (var ob in MainWindow.emp_list) NamecomboBox.Items.Add(ob.Name);
        //}

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ChangeDepEmp_Click(object sender, RoutedEventArgs e)
        {
            ChangeDepEmp changeDepEmp = new ChangeDepEmp();
            changeDepEmp.Owner = this;
            changeDepEmp.ShowDialog();
        }

        private void ChangeNameEmp_Click(object sender, RoutedEventArgs e)
        {
            ChangeNameEmp changeNameEmp = new ChangeNameEmp();
            changeNameEmp.Owner = this;
            changeNameEmp.ShowDialog();
        }

        private void AddNewEmp_Click(object sender, RoutedEventArgs e)
        {
            CreateEmployee createEmp = new CreateEmployee();
            createEmp.Owner = this;
            createEmp.ShowDialog();
        }
    }
}
