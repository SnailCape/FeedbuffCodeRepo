﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Cinkie_feedback_fr.FeedBUFClasses;

namespace Cinkie_feedback_fr.DAL
{
    internal class DAL
    {
        public string connectionString = "Data Source=localhost;Initial Catalog=COEUS_DB;Integrated Security=True";
        public DAL() { }

        

        /// <summary>
        /// Add a new student to the database
        /// </summary>
        public void CreateNewStudent(FeedBUFClasses.Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    // Couldn't fix it
                    // Moet student en adres opslaan
                }
                connection.Close();
            }
        }

        /// <summary>
        /// Get a list of all the students in the database
        /// </summary>
        /// <returns></returns>
        public List<FeedBUFClasses.Student> ReadStudents()
        {
            List<FeedBUFClasses.Student> students = new List<FeedBUFClasses.Student>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT STUDENT.studentId, STUDENT.klasId, STUDENT.voornaam, STUDENT.achternaam, STUDENT.geslacht, STUDENT.emailadres, STUDENT.telefoonnummer, STUDENT.postcode, ADRES.land, ADRES.stad, ADRES.straatnaam, ADRES.huisnummer, STUDENT.schoolLocatie FROM STUDENT JOIN ADRES ON STUDENT.postcode = ADRES.postcode";

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            int studentId = Int32.Parse(dataReader[0].ToString());
                            int classId = Int32.Parse(dataReader[1].ToString());
                            string firstname = dataReader[2].ToString();
                            string lastname = dataReader[3].ToString();
                            string gender = dataReader[4].ToString();
                            string email = dataReader[5].ToString();
                            string phonenumber = dataReader[6].ToString();
                            string postalCode = dataReader[7].ToString();
                            string country = dataReader[8].ToString();
                            string city = dataReader[9].ToString();
                            string streetname = dataReader[10].ToString();
                            string housenumber = dataReader[11].ToString();
                            string schoollocation = dataReader[12].ToString();

                            students.Add(new FeedBUFClasses.Student(studentId, firstname, lastname, gender, email, phonenumber, postalCode,
                                                             country, city, streetname, housenumber, schoollocation, false, classId));
                        }
                    }
                    connection.Close();
                }
            }

            return students;
        }

        /// <summary>
        /// Get a list of all the teachers in the database
        /// </summary>
        /// <returns></returns>
        public List<FeedBUFClasses.Teacher> ReadTeachers()
        {
            List<FeedBUFClasses.Teacher> teachers = new List<FeedBUFClasses.Teacher>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT DOCENT.docentId, DOCENT.voornaam, DOCENT.achternaam, DOCENT.geslacht, DOCENT.emailadres, DOCENT.telefoonnummer, DOCENT.schoolLocatie, DOCENT.postcode, ADRES.land, ADRES.stad, ADRES.straatnaam, ADRES.huisnummer, DOCENT.oeId, ONDERWIJSEENHEID.naam, ONDERWIJSEENHEID.afdeling, ONDERWIJSEENHEID.europeanCredits, ONDERWIJSEENHEID.urenAantal FROM DOCENT JOIN ADRES ON DOCENT.postcode = ADRES.postcode JOIN ONDERWIJSEENHEID ON DOCENT.oeId = ONDERWIJSEENHEID.oeId";

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            int teacherId = Int32.Parse(dataReader[0].ToString());
                            string firstname = dataReader[1].ToString();
                            string lastname = dataReader[2].ToString();
                            string gender = dataReader[3].ToString();
                            string email = dataReader[4].ToString();
                            string phonenumber = dataReader[5].ToString();
                            string schoolLocation = dataReader[6].ToString();
                            string postalCode = dataReader[7].ToString();
                            string country = dataReader[8].ToString();
                            string city = dataReader[9].ToString();
                            string streetname = dataReader[10].ToString();
                            string housenumber = dataReader[11].ToString();
                            string studyUnitId = dataReader[12].ToString();
                            string studyUnitName = dataReader[13].ToString();
                            string studyUnitDepartment = dataReader[14].ToString();
                            int studyUnitEC = Int32.Parse(dataReader[15].ToString());
                            int studyUnitHours = Int32.Parse(dataReader[16].ToString());

                            FeedBUFClasses.StudyUnit studyunit = new FeedBUFClasses.StudyUnit(studyUnitId, studyUnitName, studyUnitDepartment, studyUnitEC, studyUnitHours);
                            teachers.Add(new FeedBUFClasses.Teacher(teacherId, firstname, lastname, gender, email, phonenumber, postalCode, country, streetname,
                                                             city, housenumber, schoolLocation, false, studyunit));
                        }
                    }
                    connection.Close();
                }
            }

            return teachers;
        }

        /// <summary>
        /// Get a list of all the classes in the database
        /// </summary>
        /// <returns></returns>
        public List<FeedBUFClasses.SchoolClass> ReadClasses()
        {
            List<FeedBUFClasses.SchoolClass> classes = new List<FeedBUFClasses.SchoolClass>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT KLAS.klasId, KLAS.docentId, KLAS.jaar, DOCENT.voornaam, DOCENT.achternaam, DOCENT.geslacht, DOCENT.emailadres, DOCENT.telefoonnummer, DOCENT.schoolLocatie, DOCENT.postcode, ADRES.land, ADRES.stad, ADRES.straatnaam, ADRES.huisnummer, DOCENT.oeId, ONDERWIJSEENHEID.naam, ONDERWIJSEENHEID.afdeling, ONDERWIJSEENHEID.europeanCredits, ONDERWIJSEENHEID.urenAantal FROM KLAS JOIN DOCENT ON KLAS.docentId = DOCENT.docentId JOIN ADRES ON DOCENT.postcode = ADRES.postcode JOIN ONDERWIJSEENHEID ON DOCENT.oeId = ONDERWIJSEENHEID.oeId";

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            int classId = Int32.Parse(dataReader[0].ToString());
                            int teacherId = Int32.Parse(dataReader[1].ToString());
                            int year = Int32.Parse(dataReader[2].ToString());
                            string firstname = dataReader[3].ToString();
                            string lastname = dataReader[4].ToString();
                            string gender = dataReader[5].ToString();
                            string email = dataReader[6].ToString();
                            string phonenumber = dataReader[7].ToString();
                            string schoollocation = dataReader[8].ToString();
                            string postalCode = dataReader[9].ToString();
                            string country = dataReader[10].ToString();
                            string city = dataReader[11].ToString();
                            string streetname = dataReader[12].ToString();
                            string housenumber = dataReader[13].ToString();
                            string studyUnitId = dataReader[14].ToString();
                            string studyUnitName = dataReader[15].ToString();
                            string studyUnitDepartment = dataReader[16].ToString();
                            int studyUnitEC = Int32.Parse(dataReader[17].ToString());
                            int studyUnitHours = Int32.Parse(dataReader[18].ToString());

                            FeedBUFClasses.StudyUnit studyUnit = new FeedBUFClasses.StudyUnit(studyUnitId, studyUnitName, studyUnitDepartment, studyUnitEC, studyUnitHours);
                            FeedBUFClasses.Teacher teacher = new FeedBUFClasses.Teacher(teacherId, firstname, lastname, gender, email, phonenumber, postalCode, country, streetname, city, housenumber, schoollocation, false, studyUnit);

                            classes.Add(new FeedBUFClasses.SchoolClass(classId, teacher, year));
                        }
                    }
                    connection.Close();
                }
            }

            return classes;
        }

        /// <summary>
        /// Get a list of all the studyunits in the database
        /// </summary>
        /// <returns></returns>
        public List<FeedBUFClasses.StudyUnit> ReadStudyUnits()
        {
            List<FeedBUFClasses.StudyUnit> studyUnits = new List<FeedBUFClasses.StudyUnit>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT ONDERWIJSEENHEID.oeId, ONDERWIJSEENHEID.naam, ONDERWIJSEENHEID.afdeling, ONDERWIJSEENHEID.europeanCredits, ONDERWIJSEENHEID.urenAantal FROM ONDERWIJSEENHEID";

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            studyUnits.Add(new FeedBUFClasses.StudyUnit(dataReader[0].ToString(), dataReader[1].ToString(),
                                                                 dataReader[2].ToString(), Int32.Parse(dataReader[3].ToString()),
                                                                 Int32.Parse(dataReader[4].ToString())
                                                                 ));
                        }
                    }
                    connection.Close();
                }
            }

            return studyUnits;
        }

        /// <summary>
        /// Get a list of all the dailytasks in the database
        /// </summary>
        /// <returns></returns>
        public List<FeedBUFClasses.DailyTask> ReadDailyTasks()
        {
            List<FeedBUFClasses.DailyTask> dailyTasks = new List<FeedBUFClasses.DailyTask>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT DAILYTASK.taskId, DAILYTASK.goalId, DAILYTASK.[status], DAILYTASK.titel, DAILYTASK.tijdsduur, DAILYTASK.omschrijving, DAILYTASK.prioriteit, DAILYTASK.moeilijkheid, DAILYTASK.typeTaak FROM DAILYTASK";

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            int taskId = Int32.Parse(dataReader[0].ToString());
                            int goalId = Int32.Parse(dataReader[1].ToString());
                            string status = dataReader[2].ToString();
                            string titel = dataReader[3].ToString();
                            string time = dataReader[4].ToString();
                            string description = dataReader[5].ToString();
                            string priority = dataReader[6].ToString();
                            string difficulty = dataReader[7].ToString();
                            string type = dataReader[8].ToString();

                            dailyTasks.Add(new FeedBUFClasses.DailyTask(taskId, status, titel, description, goalId, time, priority, difficulty, type));
                        }
                    }
                    connection.Close();
                }
            }

            return dailyTasks;
        }

        public void DalCreateDailyTask(DailyTask task)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO DAILYTASK (goalId, [status], titel, tijdsduur, omschrijving, prioriteit, moeilijkheid, typeTaak) VALUES (@goalId, @status, @title, @time, @description, @priority, @difficulty, @type)";

                    command.Parameters.AddWithValue("@goalId", task.WeeklyGoalId);
                    command.Parameters.AddWithValue("@status", task.Status);
                    command.Parameters.AddWithValue("@title", task.Titel);
                    command.Parameters.AddWithValue("@time", task.Time);
                    command.Parameters.AddWithValue("@description", task.Description);
                    command.Parameters.AddWithValue("@priority", task.Priority);
                    command.Parameters.AddWithValue("@difficulty", task.Difficulty);
                    command.Parameters.AddWithValue("@type", task.Type);

                    try { command.ExecuteNonQuery(); }
                    catch (Exception ex) { ErrorMessage(ex); MessageBox.Show($"{task.WeeklyGoalId}", "goalId", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                connection.Close();
            }
        }

        /// <summary>
        /// Create a new task in the database
        /// </summary>
        public void CreateDailyTask(DailyTask task)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO DAILYTASK (goalId, [status], titel, tijdsduur, omschrijving, prioriteit, moeilijkheid, typeTaak) VALUES (@goalId, @status, @title, @time, @description, @priority, @difficulty, @type)";

                    command.Parameters.AddWithValue("@goalId", task.WeeklyGoalId);
                    command.Parameters.AddWithValue("@status", task.Status);
                    command.Parameters.AddWithValue("@title", task.Titel);
                    command.Parameters.AddWithValue("@time", task.Time);
                    command.Parameters.AddWithValue("@description", task.Description);
                    command.Parameters.AddWithValue("@priority", task.Priority);
                    command.Parameters.AddWithValue("@difficulty", task.Difficulty);
                    command.Parameters.AddWithValue("@type", task.Type);

                    try { command.ExecuteNonQuery(); }
                    catch (Exception ex) { ErrorMessage(ex); MessageBox.Show($"{task.WeeklyGoalId}", "goalId", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                connection.Close();
            }
        }

        /// <summary>
        /// Get a list of all the weeklygoals in the database
        /// </summary>
        /// <returns></returns>
        public List<FeedBUFClasses.WeeklyGoal> ReadWeeklyGoals()
        {
            List<FeedBUFClasses.WeeklyGoal> weeklyGoals = new List<FeedBUFClasses.WeeklyGoal>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT WEEKLYGOAL.goalId, WEEKLYGOAL.studentId, WEEKLYGOAL.agenda, WEEKLYGOAL.moeilijkheid, WEEKLYGOAL.notities, WEEKLYGOAL.omschrijving, WEEKLYGOAL.prioriteit, WEEKLYGOAL.startdatum, WEEKLYGOAL.[status], WEEKLYGOAL.titel, WEEKLYGOAL.typeGoal, WEEKLYGOAL.weeknummer, WEEKLYGOAL.oeId, ONDERWIJSEENHEID.naam, ONDERWIJSEENHEID.afdeling, ONDERWIJSEENHEID.europeanCredits, ONDERWIJSEENHEID.urenAantal FROM WEEKLYGOAL JOIN ONDERWIJSEENHEID ON WEEKLYGOAL.oeId = ONDERWIJSEENHEID.oeId";

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            int goalId = Int32.Parse(dataReader[0].ToString());
                            int studentId = Int32.Parse(dataReader[1].ToString());
                            string agenda = dataReader[2].ToString();
                            string difficulty = dataReader[3].ToString();
                            string notes = dataReader[4].ToString();
                            string description = dataReader[5].ToString();
                            string priority = dataReader[6].ToString();
                            string startingdate = dataReader[7].ToString();
                            string status = dataReader[8].ToString();
                            string titel = dataReader[9].ToString();
                            string goaltype = dataReader[10].ToString();
                            int weeknumber = Int32.Parse(dataReader[11].ToString());
                            string oeId = dataReader[12].ToString();
                            string name = dataReader[13].ToString();
                            string department = dataReader[14].ToString();
                            int ec = Int32.Parse(dataReader[15].ToString());
                            int hours = Int32.Parse(dataReader[16].ToString());


                            FeedBUFClasses.StudyUnit studyunit = new FeedBUFClasses.StudyUnit(oeId,name, department, ec, hours);
                            weeklyGoals.Add(new FeedBUFClasses.WeeklyGoal(goalId, weeknumber, titel, description, status, studyunit, studentId,
                                                                          priority, difficulty, goaltype, startingdate, agenda, notes));
                        }
                    }
                    connection.Close();
                }
            }

            return weeklyGoals;
        }


        /// <summary>
        /// Create a new weekly goal in the database
        /// </summary>
        /// <param name="weeklyGoal"></param>
        /// <param name="student"></param>
        /// <param name="studyunit"></param>
        /// <returns></returns>

        public void CreateWeeklyGoal(WeeklyGoal weeklyGoal, Student student, StudyUnit studyunit)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {

                    command.Connection = connection;

                    command.CommandText = "INSERT INTO WEEKLYGOAL (WEEKLYGOAL.studentId, WEEKLYGOAL.oeId, WEEKLYGOAL.[status], WEEKLYGOAL.titel, WEEKLYGOAL.omschrijving, WEEKLYGOAL.weeknummer, WEEKLYGOAL.prioriteit, WEEKLYGOAL.moeilijkheid, WEEKLYGOAL.typeGoal, WEEKLYGOAL.startdatum, WEEKLYGOAL.agenda, WEEKLYGOAL.notities) VALUES (@studentId, @oeId, @status, @title, @description, @weeknumber, @priority, @difficulty, @type, @startingdate, @agenda, @notes)";

                    command.Parameters.AddWithValue("@studentId", student.StudentId);
                    command.Parameters.AddWithValue("@oeId", studyunit.StudyUnitId);
                    command.Parameters.AddWithValue("@status", weeklyGoal.Status);
                    command.Parameters.AddWithValue("@title", weeklyGoal.Titel);
                    command.Parameters.AddWithValue("@description", weeklyGoal.Description);
                    command.Parameters.AddWithValue("@weeknumber", weeklyGoal.Weeknumber);
                    command.Parameters.AddWithValue("@priority", weeklyGoal.Priority);
                    command.Parameters.AddWithValue("@difficulty", weeklyGoal.Difficulty);
                    command.Parameters.AddWithValue("@type", weeklyGoal.GoalType);
                    command.Parameters.AddWithValue("@startingdate", weeklyGoal.StartingDate);
                    command.Parameters.AddWithValue("@agenda", weeklyGoal.Agenda);
                    command.Parameters.AddWithValue("@notes", weeklyGoal.Notes);

                    try { command.ExecuteNonQuery(); }
                    catch (Exception ex) { ErrorMessage(ex); }
                }
                connection.Close();
            }
        }

        /// <summary>
        /// Get a list of all the feedback in the database
        /// </summary>
        /// <returns></returns>
        public List<FeedBUFClasses.Feedback> ReadFeedback()
        {
            List<FeedBUFClasses.Feedback> feedback = new List<FeedBUFClasses.Feedback>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT FEEDBACK.feedbackId, FEEDBACK.oeId, FEEDBACK.omschrijving, ONDERWIJSEENHEID.naam, ONDERWIJSEENHEID.afdeling, ONDERWIJSEENHEID.europeanCredits, ONDERWIJSEENHEID.urenAantal FROM FEEDBACK JOIN ONDERWIJSEENHEID ON FEEDBACK.oeId = ONDERWIJSEENHEID.oeId";

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            int feedbackId = Int32.Parse(dataReader[0].ToString());
                            string studyUnitId = dataReader[1].ToString();
                            string description = dataReader[2].ToString();
                            string name = dataReader[3].ToString();
                            string department = dataReader[4].ToString();
                            int EC = Int32.Parse(dataReader[5].ToString());
                            int hours = Int32.Parse(dataReader[6].ToString());

                            FeedBUFClasses.StudyUnit studyunit = new FeedBUFClasses.StudyUnit(studyUnitId, name, department, EC, hours);
                            feedback.Add(new FeedBUFClasses.Feedback(feedbackId, studyunit, description));
                        }
                    }
                    connection.Close();
                }
            }

            return feedback;
        }

        public DailyTask UpdateDailyTask(DailyTask task)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE DAILYTASK SET goalId = @WeeklyGoalId, status = @Status, titel = @Titel, tijdsduur = @Time , omschrijving = @Description, prioriteit = @Priority, moeilijkheid = @Difficulty , typeTaak = @type WHERE taskId = @DailyTaskId;";
                    command.Parameters.AddWithValue("@DailyTaskId", task.DailyTaskId);
                    command.Parameters.AddWithValue("@type", task.Type);
                    command.Parameters.AddWithValue("@Difficulty", task.Difficulty);
                    command.Parameters.AddWithValue("@Priority", task.Priority);
                    command.Parameters.AddWithValue("@Description", task.Description);
                    command.Parameters.AddWithValue("@Time", task.Time);
                    command.Parameters.AddWithValue("@Titel", task.Titel);
                    command.Parameters.AddWithValue("@Status",task.Status);
                    command.Parameters.AddWithValue("@WeeklyGoalId", task.WeeklyGoalId);
                    
                    try { command.ExecuteNonQuery(); }
                    catch(Exception ex) { ErrorMessage(ex); }
                }
                connection.Close();
            }
            return task;
        }

        public WeeklyGoal UpdateWeeklyGoal(WeeklyGoal weeklyGoal, Student student, StudyUnit studyUnit)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE WEEKLYGOAL SET studentId = @studentID, weeknummer = @weeknr, titel = @title, omschrijving = @description, status = @status, prioriteit = @prio, moeilijkheid = @difficulty, typeGoal = @goaltype, oeId = @oeID, notities = @notes, startdatum = @startingdate WHERE goalId = @goalId;";
                    command.Parameters.AddWithValue("@goalId", weeklyGoal.WeeklyGoalId);
                    command.Parameters.AddWithValue("@studentID", student.StudentId);
;                   command.Parameters.AddWithValue("@weeknr", weeklyGoal.Weeknumber);
                    command.Parameters.AddWithValue("@title", weeklyGoal.Titel);
                    command.Parameters.AddWithValue("@description", weeklyGoal.Description);
                    command.Parameters.AddWithValue("@status", weeklyGoal.Status);
                    command.Parameters.AddWithValue("@prio", weeklyGoal.Priority);
                    command.Parameters.AddWithValue("@difficulty", weeklyGoal.Difficulty);
                    command.Parameters.AddWithValue("@goaltype", weeklyGoal.GoalType);
                    command.Parameters.AddWithValue("@oeID", studyUnit.StudyUnitId);
                    command.Parameters.AddWithValue("@notes", weeklyGoal.Notes);
                    command.Parameters.AddWithValue("@startingdate", weeklyGoal.StartingDate);

                    try { command.ExecuteNonQuery(); }
                    catch (Exception ex) { ErrorMessage(ex); }
                }
                connection.Close();
            }
            return weeklyGoal;
        }

            /// <summary>
            /// Method for error messages
            /// </summary>
        private void ErrorMessage(Exception ex)
        {
            string message = $"Error bij Database!\n*{ex.Message}*";
            string title = "Error";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
