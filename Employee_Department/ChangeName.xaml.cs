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
    /// Логика взаимодействия для ChangeName.xaml
    /// </summary>
    public partial class ChangeName : Window
    {
        public ChangeName()
        {
            InitializeComponent();
            UpdateInfo();
        }

        public void UpdateInfo()
        {
            NameCombobox.Items.Clear();
            foreach (var ob in MainWindow.dep_list) NameCombobox.Items.Add(ob.Name);
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameCombobox.SelectedIndex != -1 && NewDepNameTextBox.Text != "")
            {
                MainWindow.dep_list.ElementAt(NameCombobox.SelectedIndex).Name = NewDepNameTextBox.Text;
                UpdateInfo();
                NewDepNameTextBox.Text = "";
            }
            else MessageBox.Show("Invalid Data");
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
