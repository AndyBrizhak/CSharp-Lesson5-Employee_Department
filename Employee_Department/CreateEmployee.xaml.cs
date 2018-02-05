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
    /// Логика взаимодействия для CreateEmployee.xaml
    /// </summary>
    public partial class CreateEmployee : Window
    {
        public CreateEmployee()
        {
            InitializeComponent();
            foreach (var c in MainWindow.dep_list)
                DepComboBox.Items.Add(c.Name);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void UploadNewEmpButton_Click(object sender, RoutedEventArgs e)
        {
            if (NewNameEmpTextBox.Text != ""  && DepComboBox.SelectedIndex != -1)
            {
                        
                MainWindow.emp_list.Add(new Employee(NewNameEmpTextBox.Text, MainWindow.dep_list.ElementAt(DepComboBox.SelectedIndex)));
                Close();
            }
            else MessageBox.Show("Invalid Data");
        }
    }
}
