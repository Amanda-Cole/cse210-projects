// class Library
// {
//     private List<Goal> goals = new List<Goal>();
//     private string filename;

//     public Library(string filename)
//     {
//         this.filename = filename;
//     }

//     public void AddGoal(Goal goal)
//     {
//         goals.Add(goal);
//     }

//     public void RemoveGoal(Goal goal)
//     {
//         goals.Remove(goal);
//     }

//     public void Save()
//     {
//         using (StreamWriter writer = new StreamWriter(filename))
//         {
//             foreach (Goal goal in goals)
//             {
//                 writer.WriteLine($"{goal.Name},{goal.Description},{goal.Points},{goal.IsComplete}");
//             }
//         }
//     }

//     public void Load()
//     {
//         if (File.Exists(filename))
//         {
//             goals.Clear();
//             using (StreamReader reader = new StreamReader(filename))
//             {
//                 string line;
//                 while ((line = reader.ReadLine()) != null)
//                 {
//                     string[] parts = line.Split(',');
//                     if (parts.Length == 4 && int.TryParse(parts[2], out int points) && bool.TryParse(parts[3], out bool isComplete))
//                     {
//                         goals.Add(new Goal(parts[0], parts[1], points) { IsComplete = isComplete });
//                     }
//                 }
//             }
//         }
//     }

//     public void Display()
//     {
//         int totalPoints = 0;
//         foreach (Goal goal in goals)
//         {
//             Console.WriteLine(goal);
//             if (goal.IsComplete)
//             {
//                 totalPoints += goal.Points;
//             }
//         }
//         Console.WriteLine($"Total Points: {totalPoints}");
//     }
// }
