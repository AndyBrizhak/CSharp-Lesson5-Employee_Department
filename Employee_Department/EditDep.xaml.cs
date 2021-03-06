﻿
using System.Windows;


namespace Employee_Department
{
    /// <summary>
    /// Логика взаимодействия для EditDep.xaml
    /// </summary>
    public partial class EditDep : Window
    {
        
        public EditDep()
        {
            InitializeComponent();
            Update();

        }

        public void Update()
        {
            EditDepCombobox.Items.Clear();
            foreach (var ob in MainWindow.dep_list) EditDepCombobox.Items.Add(ob.Name);
        }

        private void ChangeNameButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeName changeName = new ChangeName();
            changeName.Owner = this;
            changeName.ShowDialog();
        }

        private void CreateNewDep_Click(object sender, RoutedEventArgs e)
        {
            CreateNewDep createNewDep = new CreateNewDep();
            createNewDep.Owner = this;
            createNewDep.ShowDialog();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
