
using System.Windows;


namespace Employee_Department
{
    /// <summary>
    /// Логика взаимодействия для EditDep.xaml
    /// </summary>
    public partial class EditDep : Window
    {
        public EditDep(Department _selectedDep)
        {
            InitializeComponent();
            NameDepTextBox.Text = _selectedDep.Name;

        }
    }
}
