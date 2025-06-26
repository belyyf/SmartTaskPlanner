using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using SmartTaskPlanner.Models;

namespace SmartTaskPlanner.Services
{
    public static class JsonService
    {
        public static void SaveTasksToJson(string path, List<TaskModel> tasks)
        {
            var json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }

        public static List<TaskModel> LoadTasksFromJson(string path)
        {
            if (!File.Exists(path))
                return new List<TaskModel>();

            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<TaskModel>>(json);
        }
    }
}
