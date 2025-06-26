using System.Collections.Generic;
using System.Linq;
using System.Windows;
using SmartTaskPlanner.Models;
using SmartTaskPlanner.Services;

namespace SmartTaskPlanner.Views
{
    public partial class MainWindow : Window
    {
        public ViewModels.MainViewModel ViewModel => DataContext as ViewModels.MainViewModel;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var newTask = new TaskModel();
            var dialog = new TaskDialog(newTask);
            if (dialog.ShowDialog() == true)
            {
                ViewModel.Tasks.Add(newTask);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.SelectedTask != null)
            {
                ViewModel.Tasks.Remove(ViewModel.SelectedTask);
            }
        }

        private void SaveJson_Click(object sender, RoutedEventArgs e)
        {
            JsonService.SaveTasksToJson("tasks.json", ViewModel.Tasks.ToList());
            MessageBox.Show("Сохранено в tasks.json");
        }

        private void LoadJson_Click(object sender, RoutedEventArgs e)
        {
            var loaded = JsonService.LoadTasksFromJson("tasks.json");
            ViewModel.Tasks.Clear();
            foreach (var t in loaded)
                ViewModel.Tasks.Add(t);
        }
    }
}
