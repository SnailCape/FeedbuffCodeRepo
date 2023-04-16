using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cinkie_feedback_fr.FeedBUFClasses
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
        public int StudentId { get; set; }
        public string Priority { get; set; }
        public string Difficulty { get; set; }
        public string GoalType { get; set; }
        public string StartingDate { get; set; }
        public string Agenda { get; set; }
        public string Notes { get; set; }
        

        public List<WeeklyGoal> listWeeklyGoals = new List<WeeklyGoal>();

        public WeeklyGoal() { }
        public WeeklyGoal(int weeklyGoalId, int weeknumber, string titel, string description, string status, StudyUnit studyunit,
                          Student student, string priority, string difficulty, string goaltype, string startingdate, string agenda, string notes)
        {
            WeeklyGoalId = weeklyGoalId;
            Weeknumber = weeknumber;
            Titel = titel;
            Description = description;
            Status = status;
            studyUnit = studyunit;
            this.student = student;
            Priority = priority;
            Difficulty = difficulty;
            GoalType = goaltype;
            StartingDate = startingdate;
            Agenda = agenda;
            Notes = notes;
            
            
        }
        public WeeklyGoal(int weeklyGoalId, int weeknumber, string titel, string description, string status, StudyUnit studyUnit,
                          int studentId, string priority, string difficulty, string goaltype, string startingdate, string agenda, string notes)
        {
            WeeklyGoalId = weeklyGoalId;
            Weeknumber = weeknumber;
            Titel = titel;
            Description = description;
            Status = status;
            this.studyUnit = studyUnit;
            StudentId = studentId;
            Priority = priority;
            Difficulty = difficulty;
            GoalType = goaltype;
            StartingDate = startingdate;
            Agenda = agenda;
            Notes = notes;
            
        }

        /// <summary>
        /// Save the list of weeklygoals from the database into the class
        /// </summary>
        public List<WeeklyGoal> GetWeeklyGoalsFromDB()
        {
            return dal.ReadWeeklyGoals();
        }

        /// <summary>
        /// Get a list of all weekly goals saved into the class
        /// </summary>
        /// <returns></returns>
        public List<WeeklyGoal> GetWeeklyGoalsFromClass()
        {
            listWeeklyGoals.Clear();
            listWeeklyGoals = dal.ReadWeeklyGoals();
            ConnectGoalWithStudent();
            return listWeeklyGoals;
        }

        /// <summary>
        /// Connect the weekly goals to their corresponding students
        /// </summary>
        public void ConnectGoalWithStudent()
        {
            Student studentMain = new Student();
            foreach (WeeklyGoal goal in GetWeeklyGoalsFromDB())
            {
                foreach (Student student in studentMain.GetStudentsFromDB())
                {
                    if (goal.StudentId == student.StudentId)
                    {
                        listWeeklyGoals.Remove(goal);
                        listWeeklyGoals.Add(new WeeklyGoal(goal.WeeklyGoalId, goal.Weeknumber, goal.Titel, goal.Description, goal.Status, goal.studyUnit, student,
                                                              goal.Priority, goal.Difficulty, goal.GoalType, goal.StartingDate, goal.Agenda, goal.Notes));
                    }
                }
            }
        }

        /// <summary>
        /// Create a new weekly goal and add it to the list AND database
        /// </summary>
        public WeeklyGoal CreateWeeklyGoal(WeeklyGoal weeklyGoal)
        {
            return dal.CreateWeeklyGoal(weeklyGoal);
        }

        /// <summary>
        /// Delete a weekly goal based on id from the list AND database
        /// </summary>
        public void DeleteWeeklyGoal()
        {
            //delete weekly goals is no option.
        }

        /// <summary>
        /// Update a weekly goal from the list AND database
        /// </summary>
        public WeeklyGoal UpdateWeeklyGoal(WeeklyGoal weeklyGoal)
        {
            return dal.UpdateWeeklyGoal(weeklyGoal);
        }
    }
}
