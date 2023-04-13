    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinkie_feedback_fr.FeedBUFClasses
{
    internal class Student
    {
        DAL.DAL dal = new DAL.DAL();
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Streetname { get; set; }
        public string Housenumber { get; set; }
        public string SchoolLocation { get; set; }
        public bool LoginStatus { get; set; }
        public int StudentClassId { get; set; }
        public SchoolClass StudentClass { get; set; }
        public List<Student> listStudents = new List<Student>();

        // Empty Student object
        public Student() { }
        // Student object with class index
        public Student(int studentId, string firstName, string lastName,
                       string gender, string email, string phonenumber,
                       string postalcode, string country, string city,
                       string streetname, string housenumber, string schoollocation,
                       bool loginstatus, int studentclassId)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Email = email;
            Phonenumber = phonenumber;
            PostalCode = postalcode;
            Country = country;
            City = city;
            Streetname = streetname;
            Housenumber = housenumber;
            SchoolLocation = schoollocation;
            LoginStatus = loginstatus;
            StudentClassId = studentclassId;
        }
        // Student object with class object
        public Student(int studentId, string firstName, string lastName,
                       string gender, string email, string phonenumber,
                       string postalcode, string country, string city,
                       string streetname, string housenumber, string schoollocation,
                       bool loginstatus, SchoolClass studentclass)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Email = email;
            Phonenumber = phonenumber;
            PostalCode = postalcode;
            Country = country;
            City = city;
            Streetname = streetname;
            Housenumber = housenumber;
            SchoolLocation = schoollocation;
            LoginStatus = loginstatus;
            StudentClass = studentclass;
        }

        /// <summary>
        /// Save the list of students from the database into the class
        /// </summary>
        public void GetStudentsFromDB()
        {
            listStudents.Clear();
            listStudents = dal.ReadStudents();
            ConnectStudentsWithClasses();
        }

        /// <summary>
        /// Get the saved list of students from the class
        /// </summary>
        /// <return></return>
        public List<Student> GetStudentsFromClass()
        {
            return listStudents;
        }

        /// <summary>
        /// Connect each student with their corresponding class
        /// </summary>
        public void ConnectStudentsWithClasses()
        {
            SchoolClass schoolClass = new SchoolClass();
            foreach (Student student in listStudents)
            {
                foreach (SchoolClass schoolclass in schoolClass.GetClassesFromClass())
                {
                    if (student.StudentClassId == schoolClass.ClassId)
                    {
                        newListStudents.Add(new Student(student.StudentId, student.FirstName, student.LastName, student.Gender, student.Email, student.Phonenumber,
                                                        student.PostalCode, student.Country, student.City, student.Streetname, student.Housenumber, student.SchoolLocation,
                                                        student.LoginStatus, schoolclass));
                    }
                }
            }
        }

        /// <summary>
        /// Add a new student to the list and to the database
        /// </summary>
        public void CreateStudent(Student student)
        {
            // Add the new student to the database --> Not complete yet
            dal.CreateNewStudent(student);
            // Add student to the list of students
            listStudents.Add(student);
            // Connect all students in the list of students to their classes
            ConnectStudentsWithClasses();
        }
    }
}
