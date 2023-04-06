using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinkie_feedback_fr.DAL
{
    internal class DAL
    {
        public string connectionstring = "Data Source=localhost;Initial Catalog=COEUS_DB;Integrated Security=True";
        public DAL() { }

        /// <summary>
        /// Get a list of all the students in the database
        /// </summary>
        /// <returns></returns>
        public List<Classes.Student> ReadStudents()
        {
            List<Classes.Student> students = new List<Classes.Student>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @$"SELECT STUDENT.studentId, STUDENT.klasId, STUDENT.voornaam, STUDENT.achternaam, STUDENT.geslacht, STUDENT.emailadres, STUDENT.telefoonnummer, STUDENT.postcode, STUDENT.land, ADRES.stad, ADRES.straatnaam, ADRES.huisnummer, STUDENT.schoolLocatie FROM STUDENT JOIN ADRES ON STUDENT.postcode = ADRES.postcode";

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

                            students.Add(new Classes.Student(studentId, firstname, lastname, gender, email, phonenumber, postalCode,
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
        public List<Classes.Teacher> ReadTeachers()
        {
            List<Classes.Teacher> teachers = new List<Classes.Teacher>();

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
                            int studyUnitId = Int32.Parse(dataReader[12].ToString());
                            string studyUnitName = dataReader[13].ToString();
                            string studyUnitDepartment = dataReader[14].ToString();
                            int studyUnitEC = Int32.Parse(dataReader[15].ToString());
                            int studyUnitHours = Int32.Parse(dataReader[16].ToString());

                            Classes.StudyUnit studyunit = new Classes.StudyUnit(studyUnitId, studyUnitName, studyUnitDepartment, studyUnitEC, studyUnitHours);
                            teachers.Add(new Classes.Teacher(teacherId, firstname, lastname, gender, email, phonenumber, postalCode, country, streetname,
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
        public List<Classes.Class> ReadClasses()
        {
            List<Classes.Class> classes = new List<Classes.Class>();

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

                            Classes.StudyUnit studyUnit = new Classes.StudyUnit(studyUnitId, studyUnitName, studyUnitDepartment, studyUnitEC, studyUnitHours);
                            Classes.Teacher teacher = new Classes.Teacher(teacherId, firstname, lastname, gender, email, phonenumber, postalCode, country, streetname, city, housenumber, schoollocation, false, studyUnit);

                            classes.Add(new Classes.Class(classId, teacher, year));
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
        public List<Classes.StudyUnit> ReadStudyUnits()
        {
            List<Classes.StudyUnit> studyUnits = new List<Classes.StudyUnit>();

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
                            studyUnits.Add(new Classes.StudyUnit(dataReader[0].ToString(), dataReader[1].ToString,
                                                                 dataReader[2].ToString(), Int32.Parse(dataReader[3].ToString),
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
        public List<Classes.DailyTask> ReadDailyTasks()
        {
            List<Classes.DailyTask> dailyTasks = new List<Classes.DailyTask>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "";

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {

                        }
                    }
                    connection.Close();
                }
            }

            return dailyTasks;
        }

        /// <summary>
        /// Get a list of all the weeklygoals in the database
        /// </summary>
        /// <returns></returns>
        public List<Classes.WeeklyGoal> ReadWeeklyGoals()
        {
            List<Classes.WeeklyGoal> weeklyGoals = new List<Classes.WeeklyGoal>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "";

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {

                        }
                    }
                    connection.Close();
                }
            }

            return weeklyGoals;
        }

        /// <summary>
        /// Get a list of all the feedback in the database
        /// </summary>
        /// <returns></returns>
        public List<Classes.Feedback> ReadFeedback()
        {
            List<Classes.Feedback> feedback = new List<Classes.Feedback>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "";

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {

                        }
                    }
                    connection.Close();
                }
            }

            return feedback;
        }
    }
}
