using System.Collections.ObjectModel;
using SmartTaskPlanner.Models;
using System.ComponentModel;

namespace SmartTaskPlanner.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<TaskModel> Tasks { get; set; }

        private TaskModel _selectedTask;
        public TaskModel SelectedTask
        {
            get => _selectedTask;
            set
            {
                _selectedTask = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedTask)));
            }
        }

        public MainViewModel()
        {
            Tasks = new ObservableCollection<TaskModel>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
