using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinkie_feedback_fr.Classes
{
    internal class WeeklyGoal
    {
        DAL.DAL dal = new DAL.DAL();
        public int WeeklyGoalId { get; set; }
        public int Weeknumber { get; set; }
        public string Titel { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public StudyUnit studyUnit { get; set; }
        public Student student { get; set; }
        public List<WeeklyGoal> listWeeklyGoals = new List<WeeklyGoal>();

        public WeeklyGoal(int weeklyGoalId, int weeknumber, string titel, string description,
                          string status, StudyUnit studyUnit, Student student)
        {
            WeeklyGoalId = weeklyGoalId;
            Weeknumber = weeknumber;
            Titel = titel;
            Description = description;
            Status = status;
            this.studyUnit = studyUnit;
            this.student = student;
        }

        /// <summary>
        /// Save the list of weeklygoals from the database into the class
        /// </summary>
        public void GetWeeklyGoalsFromDB()
        {
            listWeeklyGoals.Clear();
            listWeeklyGoals = dal.ReadWeeklyGoals();
        }

        /// <summary>
        /// Get a list of all weekly goals saved into the class
        /// </summary>
        /// <returns></returns>
        public void GetWeeklyGoalsFromClass()
        {
            return listWeeklyGoals;
        }
    }
}
