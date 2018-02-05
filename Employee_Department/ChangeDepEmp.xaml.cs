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
    /// Логика взаимодействия для ChangeDepEmp.xaml
    /// </summary>
    public partial class ChangeDepEmp : Window
    {
        public ChangeDepEmp()
        {
            InitializeComponent();
            Update();
        }

        public void Update()
        {
            DepCombobox.Items.Clear();
            foreach (var ob in MainWindow.dep_list) DepCombobox.Items.Add(ob.Name);
            NameEmpCoboBox.Items.Clear();
            foreach (var ob in MainWindow.emp_list) NameEmpCoboBox.Items.Add(ob.Name);
        }

      

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
           if( NameEmpCoboBox.SelectedIndex != -1 && DepCombobox.SelectedIndex != -1)
            {

                MainWindow.emp_list.ElementAt(NameEmpCoboBox.SelectedIndex).Dep = MainWindow.dep_list.ElementAt(DepCombobox.SelectedIndex);
                Close();
            }
            else MessageBox.Show("Invalid Data");

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
