using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Cinkie_feedback_fr.FeedBUFClasses
{
    internal class DailyTask
    {
        DAL.DAL dal = new DAL.DAL();
        public int DailyTaskId { get; set; }
        public WeeklyGoal weeklyGoal { get; set; }
        public int WeeklyGoalId { get; set; }
        public string Status { get; set; }
        public string Titel { get; set; }
        public string Description { get; set; }
        public string Time { get; set; }
        public string Priority { get; set; }
        public string Difficulty { get; set; }
        public string Type { get; set; }
        public List<DailyTask> listDailyTasks = new List<DailyTask>();

        public DailyTask() { }
        public DailyTask(int dailyTaskId, string status, string titel, 
                         string description, WeeklyGoal weeklyGoal,
                         string time, string priority, string difficulty, string type)
        {
            DailyTaskId = dailyTaskId;
            this.weeklyGoal = weeklyGoal;
            Status = status;
            Titel = titel;
            Description = description;
            Time = time;
            Priority = priority;
            Difficulty = difficulty;
            Type = type;
        }
        public DailyTask(int dailyTaskId, string status, string titel,
                         string description, int weeklyGoalId,
                         string time, string priority, string difficulty, string type)
        {
            DailyTaskId = dailyTaskId;
            WeeklyGoalId = weeklyGoalId;
            Status = status;
            Titel = titel;
            Description = description;
            Time = time;
            Priority = priority;
            Difficulty = difficulty;
            Type = type;
        }

        /// <summary>
        /// Save the list of dailytasks from the database into the class
        /// </summary>
        public void GetDailyTasksFromDB()
        {
            listDailyTasks.Clear();
            listDailyTasks = dal.ReadDailyTasks();
        }

        /// <summary>
        /// Get the saved list of dailytasks from the class
        /// </summary>
        /// <return></return>
        public List<DailyTask> GetDailyTasksFromClass()
        {
            listDailyTasks.Clear();
            listDailyTasks = dal.ReadDailyTasks();
            return listDailyTasks;
        }

        /// <summary>
        /// Connect the daily tasks to their corresponding weekly goals
        /// </summary>
        public void ConnectTaskWithGoal()
        {
            WeeklyGoal weeklyGoal = new WeeklyGoal();
            List<DailyTask> newListDailyTasks = new List<DailyTask>();

            foreach (DailyTask task in listDailyTasks)
            {
                foreach (WeeklyGoal goal in weeklyGoal.GetWeeklyGoalsFromClass())
                {
                    if (task.WeeklyGoalId == goal.WeeklyGoalId)
                    {
                        newListDailyTasks.Add(new DailyTask(task.DailyTaskId, task.Status, task.Titel, task.Description, goal, task.Time, task.Priority, task.Difficulty, task.Type));
                    }
                }
            }

            listDailyTasks = newListDailyTasks;
        }

        /// <summary>
        /// Create a new daily task and add it to the list AND database
        /// </summary>
        public void CreateDailyTask()
        {

        }

        /// <summary>
        /// Delete a daily task based on id from the list AND database
        /// </summary>
        public void DeleteDailyTask(int id)
        {
            //delete by ID

        }

        /// <summary>
        /// Update a daily task from the list AND database
        /// </summary>
        public void UpdateDailyTask(DailyTask task)
        {
            dal.UpdateDailyTask(task);
        }


    }
}
