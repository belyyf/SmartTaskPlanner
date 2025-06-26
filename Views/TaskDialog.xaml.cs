using System.Windows;
using SmartTaskPlanner.Models;

namespace SmartTaskPlanner.Views
{
    public partial class TaskDialog : Window
    {
        public TaskModel Task { get; private set; }

        public TaskDialog(TaskModel task)
        {
            InitializeComponent();
            Task = task;
            DataContext = this;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
