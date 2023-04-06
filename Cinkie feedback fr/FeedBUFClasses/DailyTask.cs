using System;
using System.Collections.Generic;
using System.Linq;
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
        public int TimeStampExpected { get; set; }
        public int TimeStampRealtime { get; set; }
        public string TimeStampType { get; set; }
        public int Weeknumber { get; set; }
        public List<DailyTask> listDailyTasks = new List<DailyTask>();

        public DailyTask() { }
        public DailyTask(int dailyTaskId, string status, string titel, 
                         string description, WeeklyGoal weeklyGoal,
                         int timeStampExpected, int timeStampRealtime, string timeStampType)
        {
            DailyTaskId = dailyTaskId;
            this.weeklyGoal = weeklyGoal;
            Status = status;
            Titel = titel;
            Description = description;
            TimeStampExpected = timeStampExpected;
            TimeStampRealtime = timeStampRealtime;
            TimeStampType = timeStampType;
        }
        public DailyTask(int dailyTaskId, string status, string titel,
                         string description, int weeklyGoalId,
                         int timeStampExpected, int timeStampRealtime, string timeStampType)
        {
            DailyTaskId = dailyTaskId;
            WeeklyGoalId = weeklyGoalId;
            Status = status;
            Titel = titel;
            Description = description;
            TimeStampExpected = timeStampExpected;
            TimeStampRealtime = timeStampRealtime;
            TimeStampType = timeStampType;
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
                        newListDailyTasks.Add(new DailyTask(task.DailyTaskId, task.Status, task.Titel, task.Description, goal, task.TimeStampExpected, task.TimeStampRealtime, task.TimeStampType));
                    }
                }
            }

            listDailyTasks = newListDailyTasks;
        }
    }
}
