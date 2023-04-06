using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinkie_feedback_fr.Classes
{
    internal class DailyTask
    {
        DAL.DAL dal = new DAL.DAL();
        public int DailyTaskId { get; set; }
        public Student student { get; set; }
        public StudyUnit studyUnit { get; set; }
        public WeeklyGoal weeklyGoal { get; set; }
        public string Status { get; set; }
        public string Titel { get; set; }
        public string Description { get; set; }
        public int Weeknumber { get; set; }
        public List<DailyTask> listDailyTasks = new List<DailyTask>();

        public DailyTask() { }
        public DailyTask(int dailyTaskId, Student student, StudyUnit studyUnit,
                         string status, string titel, string description,
                         int weeknumber, WeeklyGoal weeklyGoal)
        {
            DailyTaskId = dailyTaskId;
            this.student = student;
            this.studyUnit = studyUnit;
            this.weeklyGoal = weeklyGoal;
            Status = status;
            Titel = titel;
            Description = description;
            Weeknumber = weeknumber;
        }

        /// <summary>
        /// Save the list of dailytasks from the database into the class
        /// </summary>
        public static void GetDailyTasksFromDB()
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
    }
}
