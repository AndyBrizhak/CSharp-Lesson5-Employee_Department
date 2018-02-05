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
    /// Логика взаимодействия для CreateNewDep.xaml
    /// </summary>
    public partial class CreateNewDep : Window
    {
        public CreateNewDep()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameBox.Text != "") MainWindow.dep_list.Add(new Department(NameBox.Text)); else MessageBox.Show("не указано имя");
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
        }
    }
}
