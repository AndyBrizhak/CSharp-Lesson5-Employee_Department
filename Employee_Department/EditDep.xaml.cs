
using System.Windows;


namespace Employee_Department
{
    /// <summary>
    /// Логика взаимодействия для EditDep.xaml
    /// </summary>
    public partial class EditDep : Window
    {
        //public EditDep(Department _selectedDep)
        public EditDep()
        {
            InitializeComponent();
            //NameDepTextBox.Text = _selectedDep.Name;
            Update();

        }

        public void Update()
        {
            //DepartsComboBox.Items.Clear();
            //foreach (var ob in MainWindow.dep_list) DepartsComboBox.Items.Add(ob.Name);
            EditDepCombobox.Items.Clear();
            foreach (var ob in MainWindow.dep_list) EditDepCombobox.Items.Add(ob.Name);
        }


    }
}
