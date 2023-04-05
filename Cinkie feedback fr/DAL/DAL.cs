using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinkie_feedback_fr.DAL
{
    internal class DAL
    {
        public string connectionstring = "";
        public DAL() { }

        /// <summary>
        /// Get a list of all the students in the database
        /// </summary>
        /// <returns></returns>
        public List<Classes.Student> ReadStudents()
        {
            List<Classes.Student> students = new List<Classes.Student>();
            return students;
        }

        /// <summary>
        /// Get a list of all the teachers in the database
        /// </summary>
        /// <returns></returns>
        public List<Classes.Teacher> ReadTeachers()
        {
            List<Classes.Teacher> teachers = new List<Classes.Teacher>();
            return teachers;
        }

        /// <summary>
        /// Get a list of all the classes in the database
        /// </summary>
        /// <returns></returns>
        public List<Classes.Class> ReadClasses()
        {
            List<Classes.Class> classes = new List<Classes.Class>();
            return classes;
        }

        /// <summary>
        /// Get a list of all the studyunits in the database
        /// </summary>
        /// <returns></returns>
        public List<Classes.StudyUnit> ReadStudyUnits()
        {
            List<Classes.StudyUnit> studyUnits = new List<Classes.StudyUnit>();
            return studyUnits;
        }

        /// <summary>
        /// Get a list of all the dailytasks in the database
        /// </summary>
        /// <returns></returns>
        public List<Classes.DailyTask> ReadDailyTasks()
        {
            List<Classes.DailyTask> dailyTasks = new List<Classes.DailyTask>();
            return dailyTasks;
        }

        /// <summary>
        /// Get a list of all the weeklygoals in the database
        /// </summary>
        /// <returns></returns>
        public List<Classes.WeeklyGoal> ReadWeeklyGoals()
        {
            List<Classes.WeeklyGoal> weeklyGoals = new List<Classes.WeeklyGoal>();
            return weeklyGoals;
        }
    }
}
