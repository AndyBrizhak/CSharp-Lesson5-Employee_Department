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
    /// Логика взаимодействия для ChangeNameEmp.xaml
    /// </summary>
    public partial class ChangeNameEmp : Window
    {
        public ChangeNameEmp()
        {
            InitializeComponent();
            UpdateInfo();
        }
        public void UpdateInfo()
        {
            NameEmpComboBox.Items.Clear();
            foreach (var ob in MainWindow.emp_list) NameEmpComboBox.Items.Add(ob.Name);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ConfirmLabel_Click(object sender, RoutedEventArgs e)
        {
            if (NameEmpComboBox.SelectedIndex != -1 && NameEmpComboBox.Text != "")
            {
              //MainWindow.dep_list.ElementAt(NameCombobox.SelectedIndex).Name = NewDepNameTextBox.Text;
                MainWindow.emp_list.ElementAt(NameEmpComboBox.SelectedIndex).Name = NewNameTextBox.Text;
                //UpdateInfo();
                NameEmpComboBox.Text = "";
            }
            else MessageBox.Show("Invalid Data");
        }
    }
}
